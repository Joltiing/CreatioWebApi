using CreatioWebApi.ResponseModels;
using Models.Models;

namespace CreatioWebApi.Providers
{
	/// <summary>
	/// Провайдер для работы с бд.
	/// </summary>
	public class DbProvider
	{
		/// <summary>
		/// Контекст бд.
		/// </summary>
		private readonly StudioEnu41189260930Context _context;

		/// <summary>
		/// Создает экземпляр провайдера.
		/// </summary>
		public DbProvider()
		{
			_context = new StudioEnu41189260930Context();
		}

		/// <summary>
		/// Получает из бд всех пользователей системы.
		/// </summary>
		/// <returns> Список пользователей. </returns>
		public List<SystemUser> GetSystemUsers()
		{
			var userList = new List<SystemUser>();

			using (_context)
			{
				var users = _context.SysAdminUnits
					.Where(user => user.SysAdminUnitTypeValue == 4).ToList();

				foreach (var user in users)
				{
					userList.Add(SerializeUser(user));
				}
			}

			return userList;
		}

		/// <summary>
		/// Получает конкретного пользователя системы.
		/// </summary>
		/// <param name="userId"> Идентификатор пользователя. </param>
		/// <returns> Пользователь системы. </returns>
		public SystemUser GetUserById(Guid userId)
		{
			if (userId == Guid.Empty)
			{
				throw new ArgumentNullException(nameof(userId), "Идентификатор пользователя не должен быть пустым!");
			}

			using (_context)
			{
				var users = _context.SysAdminUnits.ToList();

				var user = users.First(user => user.Id == userId);

				return SerializeUser(user);
			}
		}

		/// <summary>
		/// Добавляет или обновляет существующего пользователя.
		/// </summary>
		/// <param name="user"> Данные для изменения / добавления. </param>
		/// <returns> Количество измененных строк. </returns>
		/// <exception cref="ArgumentNullException"> Пользователь = null. </exception>
		public int CreateOrUpdateUser(SystemUser user)
		{
			if (user == null)
			{
				throw new ArgumentNullException(nameof(user), "Пользователь не должен быть пустым!");
			}

			using (_context)
			{
				var userExists = _context.SysAdminUnits.Where(userDb => userDb.Id == user.Id).ToList();

				if (userExists.Count > 0)
				{
					var userInDb = _context.SysAdminUnits.First(userDb => userDb.Id == user.Id);
					userInDb.AccountId = user.AccountId == Guid.Empty ? userInDb.AccountId : user.AccountId;
					userInDb.ContactId = user.ContactId == Guid.Empty ? userInDb.ContactId : user.ContactId;
					userInDb.Name = user.Name;
					userInDb.Email = user.Email;
					userInDb.ModifiedOn = DateTime.Now;
					return _context.SaveChanges();
				}

				var newUser = new SysAdminUnit
				{
					Id = user.Id == Guid.Empty ? Guid.NewGuid() : user.Id,
					Name = user.Name,
					Email = user.Email,
					SysAdminUnitTypeValue = 4
				};

				if (user.ContactId != Guid.Empty)
				{
					newUser.ContactId = user.ContactId;
				}

				if (user.AccountId != Guid.Empty)
				{
					newUser.AccountId = user.AccountId;
				}

				_context.SysAdminUnits.Add(newUser);

				return _context.SaveChanges(true);
			}
		}

		/// <summary>
		/// Создает пользователя из основных колонок бд.
		/// </summary>
		/// <param name="user"> Исходный пользователь системы. </param>
		/// <returns> Пользователь системы. </returns>
		private SystemUser SerializeUser(SysAdminUnit user)
		{
			return new SystemUser()
			{
				AccountId = user.AccountId ?? Guid.Empty,
				ContactId = user.ContactId ?? Guid.Empty,
				Email = user.Email,
				CreatedOn = user.CreatedOn ?? DateTime.MinValue,
				Id = user.Id,
				Name = user.Name,
				UpdatedOn = user.ModifiedOn ?? DateTime.MinValue,
			};
		}

		/// <summary>
		/// Деактивирует пользователя.
		/// </summary>
		/// <param name="userId"> Идентификатор пользователя. </param>
		/// <returns> Был ли деактивирован. </returns>
		public bool DeactivateUser(Guid userId)
		{
			if (userId == Guid.Empty)
			{
				throw new ArgumentNullException(nameof(userId), "Идентификатор пользователя не должен быть пустым!");
			}

			using (_context)
			{
				var userInDb = _context.SysAdminUnits.First(userDb => userDb.Id == userId);

				userInDb.Active = false;

				return _context.SaveChanges() > 0;
			}
		}

		/// <summary>
		/// Активирует пользователя.
		/// </summary>
		/// <param name="userId"> Идентификатор пользователя. </param>
		/// <returns> Был ли активирован. </returns>
		public bool ActivateUser(Guid userId)
		{
			if (userId == Guid.Empty)
			{
				throw new ArgumentNullException(nameof(userId), "Идентификатор пользователя не должен быть пустым!");
			}

			using (_context)
			{
				var userInDb = _context.SysAdminUnits.First(userDb => userDb.Id == userId);

				userInDb.Active = true;

				return _context.SaveChanges() > 0;
			}
		}
	}
}

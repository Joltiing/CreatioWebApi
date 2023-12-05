using AngularWebApi.Providers;
using AngularWebApi.ResponseModels;
using Microsoft.AspNetCore.Mvc;

namespace AngularWebApi.Controllers
{
	/// <summary>
	/// Контроллер для работы с пользователями системы.
	/// </summary>
	[ApiController]
	[Route("api/User/[action]")]
	public class UserController : ControllerBase
	{
		/// <summary>
		/// Получает всех пользователей системы.
		/// </summary>
		/// <returns> Список пользователей системы. </returns>
		[HttpGet(Name = "GetAllUsers")]
		public IEnumerable<SystemUser> GetAllUsers()
		{
			var provider = new DbProvider();

			return provider.GetSystemUsers();
		}

		/// <summary>
		/// Получает конкретного пользователя системы.
		/// </summary>
		/// <param name="id"> Идентификатор пользователя. </param>
		/// <returns> Пользователь системы. </returns>
		[HttpGet(Name = "GetUser/{id}")]
		public SystemUser GetUser(Guid id)
		{
			var provider = new DbProvider();

			return provider.GetUserById(id);
		}

		/// <summary>
		/// Добавляет или обновляет существующего пользователя.
		/// </summary>
		/// <param name="id"> Идентификатор пользователя. </param>
		/// <param name="name"> Имя пользователя. </param>
		/// <param name="contactId"> Идентификатор контакта. </param>
		/// <param name="accountId"> Идентификатор контрагента. </param>
		/// <param name="email"> Электронная почта. </param>
		/// <returns> Количество измененных строк. </returns>
		[HttpPut(Name = "PostUser")]
		public int PostUser(Guid id, string name, Guid contactId, Guid accountId, string email)
		{
			var provider = new DbProvider();

			var user = new SystemUser();

			if (contactId != Guid.Empty)
			{
				user.ContactId = contactId;
			}

			if (accountId != Guid.Empty)
			{
				user.AccountId = accountId;
			}

			user.Id = id;
			user.Name = name;
			user.Email = email;

			var edited = provider.CreateOrUpdateUser(user);

			return edited;
		}

		/// <summary>
		/// Деактивирует пользователя.
		/// </summary>
		/// <param name="id"> Идентификатор пользователя. </param>
		/// <returns> Был ли деактивирован. </returns>
		[HttpPatch(Name = "DeactivateUser/{id}")]
		public bool DeactivateUser(Guid id)
		{
			var provider = new DbProvider();

			return provider.DeactivateUser(id);
		}

		/// <summary>
		/// Активирует пользователя.
		/// </summary>
		/// <param name="id"> Идентификатор пользователя. </param>
		/// <returns> Был ли активирован. </returns>
		[HttpPatch(Name = "ActivateUser/{id}")]
		public bool ActivateUser(Guid id)
		{
			var provider = new DbProvider();

			return provider.ActivateUser(id);
		}
	}
}
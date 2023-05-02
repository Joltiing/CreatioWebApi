using CreatioWebApi.Providers;
using CreatioWebApi.ResponseModels;
using Microsoft.AspNetCore.Mvc;

namespace CreatioWebApi.Controllers
{
	/// <summary>
	/// ���������� ��� ������ � �������������� �������.
	/// </summary>
	[ApiController]
	[Route("api/[controller]/[action]")]
	public class UserController : ControllerBase
	{
		/// <summary>
		/// �������� ���� ������������� �������.
		/// </summary>
		/// <returns> ������ ������������� �������. </returns>
		[HttpGet(Name = "GetAllUsers")]
		public IEnumerable<SystemUser> GetUsers()
		{
			var provider = new DbProvider();

			return provider.GetSystemUsers();
		}

		/// <summary>
		/// �������� ����������� ������������ �������.
		/// </summary>
		/// <param name="id"> ������������� ������������. </param>
		/// <returns> ������������ �������. </returns>
		[HttpGet(Name = "GetUser/{id}")]
		public SystemUser GetUser(Guid id)
		{
			var provider = new DbProvider();

			return provider.GetUserById(id);
		}

		/// <summary>
		/// ��������� ��� ��������� ������������� ������������.
		/// </summary>
		/// <param name="id"> ������������� ������������. </param>
		/// <param name="name"> ��� ������������. </param>
		/// <param name="contactId"> ������������� ��������. </param>
		/// <param name="accountId"> ������������� �����������. </param>
		/// <param name="email"> ����������� �����. </param>
		/// <returns> ���������� ���������� �����. </returns>
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
		/// ������������ ������������.
		/// </summary>
		/// <param name="id"> ������������� ������������. </param>
		/// <returns> ��� �� �������������. </returns>
		[HttpPatch(Name = "DeactivateUser/{id}")]
		public bool DeactivateUser(Guid id)
		{
			var provider = new DbProvider();

			return provider.DeactivateUser(id);
		}

		/// <summary>
		/// ���������� ������������.
		/// </summary>
		/// <param name="id"> ������������� ������������. </param>
		/// <returns> ��� �� �����������. </returns>
		[HttpPatch(Name = "ActivateUser/{id}")]
		public bool ActivateUser(Guid id)
		{
			var provider = new DbProvider();

			return provider.ActivateUser(id);
		}
	}
}
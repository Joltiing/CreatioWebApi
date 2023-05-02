namespace CreatioWebApi.ResponseModels
{
	/// <summary>
	/// Пользователь системы.
	/// </summary>
	public class SystemUser
	{
		/// <summary>
		/// Идентификатор пользователя.
		/// </summary>
		public Guid Id { get; set; }

		/// <summary>
		/// Имя.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Контакт.
		/// </summary>
		public Guid ContactId { get; set; }

		/// <summary>
		/// Контрагент.
		/// </summary>
		public Guid AccountId { get; set; }

		/// <summary>
		/// Адрес электронной почты.
		/// </summary>
		public string Email { get; set; }

		/// <summary>
		/// Создан.
		/// </summary>
		public DateTime CreatedOn { get; set; }

		/// <summary>
		/// Изменен.
		/// </summary>
		public DateTime UpdatedOn { get; set; }
	}
}

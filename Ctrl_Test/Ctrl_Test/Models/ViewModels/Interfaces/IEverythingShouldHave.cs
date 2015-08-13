namespace Ctrl_Test.Models.ViewModels.Interfaces
{
	// make the T covarient
	public interface IEverythingShouldHave<out TModel>
	{
		TModel PopulateFromApplication(string db, int id);
		TModel PersistByApplication(string db, int id);
	}
}

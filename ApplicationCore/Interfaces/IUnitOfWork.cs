
namespace ApplicationCore.Interfaces
{
    public interface IUnitOfWork
    {
        IPatientRepository Patients{get;}
        IDoctorRepository Doctors{get;}
        IAccountRepository Accounts{get;}
        //IUserRepository User{get;}
        // bo sung them nhung repository khac

        int Complete();
    }
}
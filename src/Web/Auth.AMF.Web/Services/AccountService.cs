using Auth.AMF.Web.Data;
using Auth.AMF.Web.Models;
using Auth.AMF.Web.ViewModels;
using MongoDB.Driver;
using System;
using System.Threading.Tasks;

namespace Auth.AMF.Web.Services
{
    #region Interface
    public interface IAccountService
    {
        Task GetData(Guid AuthUserId);
    }
    #endregion

    #region Service
    public class AccountService : IAccountService
    {
        readonly MongoContext _mongo;

        public AccountService(MongoContext mongo)
        {
            _mongo = mongo;
        }

        public async Task GetData(Guid id)
        {
            var filterId = Builders<CreatePassword>.Filter.Eq(f => f.Id, id);
            var filterIsValid = Builders<CreatePassword>.Filter.Eq(f => f.IsValid, true);
            var teste = await _mongo.CreatePassword.Find(filterId & filterIsValid).Limit(1).FirstOrDefaultAsync();
        }
    }
    #endregion
}

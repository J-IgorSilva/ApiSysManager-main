using Dapper;
using SysManager.Application.Contracts;
using SysManager.Application.Data.MySql.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SysManager.Application.Data.MySql.Repositories
{
    public class UserRepository
    {
        private readonly MySqlContext _context;
        public UserRepository(MySqlContext ctt)
        {
            this._context = ctt;
        }

        public async Task<ResponseDefault> PostAsync(UserEntity entity)
        {
            var _query = $@"insert into user (id, username, email, password, active)
                          value(@id, @username, @email, @password, @active)";


            using (var cnx = _context.Connection())
            {
                var mapper = new
                {
                    id = entity.Id, 
                    username = entity.UserName,
                    email = entity.Email,
                    password = entity.Password,
                    active = entity.Active
                };
                var result = await cnx.ExecuteAsync(_query, mapper);

                if (result > 0)   
                    return new ResponseDefault(entity.Id.ToString(), "usuario criado", false);
            }
            return new ResponseDefault("", "Erro ao criar ususario", true);
        }
    }
}

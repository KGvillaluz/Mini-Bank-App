using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    internal class UsersService
    {
        private readonly UserRepository userRepository;
        private readonly AccountRepository accountRepository;
        public UsersService() 
        {
            userRepository = new UserRepository();
            accountRepository = new AccountRepository();
        }
        public bool signup(UsersNew users)
        {
            if (userRepository.saveUser(users))
            {
                AccountsNew account = new AccountsNew();
                if (accountRepository.createAcc(account))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            
        }

        public bool isLogin(int logAccID, int logPin)
        {
            if (userRepository.isLogin(logAccID, logPin))
            {
                DashBoard.accountID = logAccID;
                Receipt.accountID = logAccID;
                return true;
            }
            else
            { 
                return false;
            }
        }
    }
}

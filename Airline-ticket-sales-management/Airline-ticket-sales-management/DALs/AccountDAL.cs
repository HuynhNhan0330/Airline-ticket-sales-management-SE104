using Airline_ticket_sales_management.DTOs;
using Airline_ticket_sales_management.Model;
using Airline_ticket_sales_management.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline_ticket_sales_management.DALs
{
    public class AccountDAL
    {
        private static AccountDAL _ins;
        public static AccountDAL Ins
        {
            get
            {
                if (_ins == null)
                    _ins = new AccountDAL();
                return _ins;
            }
            private set => _ins = value;
        }

        public async Task<(AccountDTO, string)> login(string username, string password)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    AccountDTO account = (from ac in context.ACCOUNTs
                                          where (ac.Phone == username || ac.Email == username) && ac.Password == password
                                          join role in context.PERMISSIONs
                                          on ac.RoleID equals role.RoleID
                                          select new AccountDTO
                                          {
                                              AccountID = ac.AccountID,
                                              Name = ac.Name,
                                              Email = ac.Email,
                                              Phone = ac.Phone,
                                              Password = ac.Password,
                                              Created = DateTime.Now,
                                              RoleID = ac.RoleID,
                                              RoleName = role.RoleName
                                          }).FirstOrDefault();

                    if (account == null)
                        return (null, "Tài khoản hoặc mật khẩu không đúng");

                    account.PermissionCode = context.PERMISSIONs.First(pe => pe.RoleID == account.RoleID).PermissionCode;

                    return (account, "Đăng nhập thành công");
                }
            }
            catch (Exception ex)
            {
                return (null, ex.Message);
            }
        }

        public async Task<AccountDTO> findAccountByEmail(string email)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    AccountDTO account = (from ac in context.ACCOUNTs
                                          where ac.Email == email
                                          select new AccountDTO
                                          {
                                              AccountID = ac.AccountID,
                                              Name = ac.Name,
                                              Email = ac.Email,
                                              Phone = ac.Phone,
                                              Password = ac.Password,
                                              Created = DateTime.Now,
                                              RoleID = ac.RoleID,
                                          }).FirstOrDefault();

                    return account;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<(bool, string, string)> createAccount(AccountDTO account)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    var checkAccountByEmail = context.ACCOUNTs.FirstOrDefault(ac => ac.Email == account.Email && ac.AccountID != account.AccountID);

                    if (checkAccountByEmail != null)
                        return (false, "Email đã tồn tại", null);

                    var checkAccountByPhone = context.ACCOUNTs.FirstOrDefault(ac => ac.Phone == account.Phone && ac.AccountID != account.AccountID);

                    if (checkAccountByPhone != null)
                        return (false, "Số điện thoại đã tồn tại", null);

                    string currentMaxCode = await context.ACCOUNTs.MaxAsync(ac => ac.AccountID);
                    string newCode = Helper.nextCode(currentMaxCode, "AC");

                    ACCOUNT newAccount = new ACCOUNT
                    {
                        AccountID = newCode,
                        Name = account.Name,
                        Email = account.Email,
                        Phone = account.Phone,
                        Password = account.Password,
                        Created = account.Created,
                        RoleID = account.RoleID,
                    };

                    context.ACCOUNTs.Add(newAccount);

                    context.SaveChanges();

                    return (true, "Tạo tài khoản thành công!", newCode);
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message, null);
            }
        }

        public async Task<(bool, List<AccountDTO>, string)> getListAccount()
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    var accountList = (from ac in context.ACCOUNTs
                                      join permission in context.PERMISSIONs
                                      on ac.RoleID equals permission.RoleID
                                      select new AccountDTO
                                      {
                                            AccountID = ac.AccountID,
                                            Name = ac.Name,
                                            Email = ac.Email,
                                            Phone = ac.Phone,
                                            Password = ac.Password,
                                            Created = (DateTime)ac.Created,
                                            RoleID = ac.RoleID,
                                            RoleName = permission.RoleName,
                                            PermissionCode = permission.PermissionCode
                                      }).ToListAsync();

                    return (true, await accountList, "Lấy danh sách tài khoản thành công!");
                }
            }
            catch (Exception ex)
            {
                return (false, null, ex.Message);
            }
        }

        public async Task<(bool, string)> deleteAccount(string accountID)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    ACCOUNT accountDelete = context.ACCOUNTs.FirstOrDefault(ac => ac.AccountID == accountID);

                    context.ACCOUNTs.Remove(accountDelete);
                    context.SaveChanges();

                    return (true, "Xoá thành công");
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public async Task<(bool, string)> updateAccount(AccountDTO account)
        {
            try
            {
                using (var context = new FlightTicketManagementEntities())
                {
                    var checkAccountByEmail = context.ACCOUNTs.FirstOrDefault(ac => ac.Email == account.Email && ac.AccountID != account.AccountID);

                    if (checkAccountByEmail != null)
                        return (false, "Email đã tồn tại");

                    var checkAccountByPhone = context.ACCOUNTs.FirstOrDefault(ac => ac.Phone == account.Phone && ac.AccountID != account.AccountID);

                    if (checkAccountByPhone != null)
                        return (false, "Số điện thoại đã tồn tại");

                    ACCOUNT currentAccount = context.ACCOUNTs.FirstOrDefault(ac => ac.AccountID == account.AccountID);
                    currentAccount.Name = account.Name;
                    currentAccount.Password = account.Password;
                    currentAccount.Email = account.Email;
                    currentAccount.Phone = account.Phone;
                    currentAccount.RoleID = account.RoleID;

                    context.SaveChanges();

                    return (true, "Cập nhật thành công");
                }
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }
    }
}

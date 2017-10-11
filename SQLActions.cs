using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServiceCentre
{
    class SQLActions
    {

        private SqlConnection con;
        private SqlCommand com;
        private SqlConnectionStringBuilder conBuilder;

        public SQLActions()
        {
            try
            {
                 con = new SqlConnection();
                   conBuilder = new SqlConnectionStringBuilder();
                   conBuilder.InitialCatalog = "SC";
                   conBuilder.DataSource = "(local)";
                   conBuilder.IntegratedSecurity = true;
                   con.ConnectionString = conBuilder.ConnectionString;

             /*   con = new SqlConnection();
                conBuilder = new SqlConnectionStringBuilder();
                conBuilder.InitialCatalog = "SC";
                conBuilder.DataSource = "10.1.100.53";
                conBuilder.IntegratedSecurity = false;
                conBuilder.UserID = "user1";
                conBuilder.Password = "user1";
                con.ConnectionString = conBuilder.ConnectionString;*/
            }
            catch
            {
                   con = new SqlConnection();
                   conBuilder = new SqlConnectionStringBuilder();
                   conBuilder.InitialCatalog = "SC";
                   conBuilder.DataSource = "(local)";
                   conBuilder.IntegratedSecurity = true;
                   con.ConnectionString = conBuilder.ConnectionString;
            }
        }


        public bool EditRepair(int idRepair, string nameClient, string nameCategory, string nameBrand, string nameModel, string SN
    , string typeRepair, string defect, string kitView, string engineer, string result, int price, string statusRepair)
        {
            try
            {
                com = new SqlCommand("EditRepair", con);
                com.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter param = com.Parameters.AddWithValue("@idRepair", idRepair);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@nameClient", nameClient);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@nameCategory", nameCategory);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@nameBrand", nameBrand);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@nameModel", nameModel);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@SN", SN);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@typeRepair", typeRepair);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@defect", defect);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@kitView", kitView);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@engineer", engineer);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@result", result);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@price", price);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@statusRepair", statusRepair);
                param.Direction = System.Data.ParameterDirection.Input;

                con.Open();
                if (com.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Нет подключения к БД, ремонт не был изменен!");
                    return false;
                }

                else
                {
                    return true;
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
            finally
            {
                com.Dispose();
                con.Close();
            }
        }


        public bool AddRepair(string nameClient, string nameCategory, string nameBrand, string nameModel, string SN
            , string typeRepair, string defect, string kitView, string engineer, string result, int price, string statusRepair)
        {
            try
            {
                com = new SqlCommand("AddRepair", con);
                com.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter param = com.Parameters.AddWithValue("@nameClient", nameClient);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@nameCategory", nameCategory);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@nameBrand", nameBrand);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@nameModel", nameModel);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@SN", SN);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@typeRepair", typeRepair);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@defect", defect);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@kitView", kitView);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@engineer", engineer);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@result", result);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@price", price);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@statusRepair", statusRepair);
                param.Direction = System.Data.ParameterDirection.Input;

                con.Open();
                if (com.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Нет подключения к БД, ремонт не добавлен!");
                    return false;
                }

                else
                {
                    return true;
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
            finally
            {
                com.Dispose();
                con.Close();
            }
        }

        public bool AddClient(string nameClient, string contact, string phone, string address, string email)
        {
            try
            {
                com = new SqlCommand("AddClient", con);
                com.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter param = com.Parameters.AddWithValue("@nameClient", nameClient);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@contact", contact);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@phone", phone);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@address", address);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@email", email);
                param.Direction = System.Data.ParameterDirection.Input;

                con.Open();
                if (com.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Нет подключения к БД, категория не была добавлена!");
                    return false;
                }

                else
                {
                    return true;
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
            finally
            {
                com.Dispose();
                con.Close();
            }
        }

           public bool EditModel(string oldNameModel, string newNameModel, string nameCategory, string nameBrand)
           {
               try
               {
                   com = new SqlCommand("EditModel", con);
                   com.CommandType = System.Data.CommandType.StoredProcedure;

                   SqlParameter param = com.Parameters.AddWithValue("@oldNameModel", oldNameModel);
                   param.Direction = System.Data.ParameterDirection.Input;

                   param = com.Parameters.AddWithValue("@newNameModel", newNameModel);
                   param.Direction = System.Data.ParameterDirection.Input;

                   param = com.Parameters.AddWithValue("@nameCategory", nameCategory);
                   param.Direction = System.Data.ParameterDirection.Input;

                   param = com.Parameters.AddWithValue("@nameBrand", nameBrand);
                   param.Direction = System.Data.ParameterDirection.Input;

                   con.Open();
                   if (com.ExecuteNonQuery() == 0)
                   {
                      // MessageBox.Show("Нет подключения к БД, модель не была добавлен!");
                       return false;
                   }

                   else
                   {
                       return true;
                   }

               }
               catch (SqlException ex)
               {
                   MessageBox.Show(ex.Message);
                   return true;
               }
               finally
               {
                   com.Dispose();
                   con.Close();
               }
           }

        public bool EditClient(string oldNameClient, string newNameClient, string contact, string phone, string address, string email)
        {
            try
            {
                com = new SqlCommand("EditClient", con);
                com.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter param = com.Parameters.AddWithValue("@oldNameClient", oldNameClient);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@newNameClient", newNameClient);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@contact", contact);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@phone", phone);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@address", address);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@email", email);
                param.Direction = System.Data.ParameterDirection.Input;

                con.Open();
                if (com.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Нет подключения к БД, клиент не был добавлен!");
                    return false;
                }

                else
                {
                    return true;
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
            finally
            {
                com.Dispose();
                con.Close();
            }
        }

        public bool EditBrand(string oldNameBrand, string @oldNameCategory, string @newNameBrand, string @newNameCategory)
        {
            try
            {
                com = new SqlCommand("EditBrand", con);
                com.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter param = com.Parameters.AddWithValue("@oldNameBrand", oldNameBrand);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@oldNameCategory", @oldNameCategory);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@newNameBrand", @newNameBrand);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@newNameCategory", @newNameCategory);
                param.Direction = System.Data.ParameterDirection.Input;

                con.Open();
                if (com.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Нет подключения к БД, бренд не был добавлен!");
                    return false;
                }

                else
                {
                    return true;
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
            finally
            {
                com.Dispose();
                con.Close();
            }
        }

        public bool AddModel(string nameModel, string nameBrand, string nameCategory)
        {
            try
            {
                com = new SqlCommand("AddModel", con);
                com.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter param = com.Parameters.AddWithValue("@nameModel", nameModel);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@nameBrand", nameBrand);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@nameCategory", nameCategory);
                param.Direction = System.Data.ParameterDirection.Input;

                con.Open();
                if (com.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Нет подключения к БД, категория не была добавлена!");
                    return false;
                }

                else
                {
                    return true;
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
            finally
            {
                com.Dispose();
                con.Close();
            }
        }
        public string getNameCategoryByIdModel(int id)
        {
            string tmp = "";
            com = new SqlCommand("getNameCategoryByIdModel", con);
            com.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter param = com.Parameters.AddWithValue("@id", id);
            param.Direction = System.Data.ParameterDirection.Input;
            con.Open();
            SqlDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                tmp = r.GetString(0);
            }
            con.Close();
            return tmp;
        }

        public string getNameBrandByIdModel(int id)
        {
            string tmp = "";
            com = new SqlCommand("getNameBrandByIdModel", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter param = com.Parameters.AddWithValue("@idModel", id);
            param.Direction = System.Data.ParameterDirection.Input;
            con.Open();
            SqlDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                tmp = r.GetString(0);
            }
            con.Close();
            return tmp;
        }

        public string getNameModelByIdModel(int id)
        {
            string tmp = "";
            com = new SqlCommand("getNameModelByIdModel", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter param = com.Parameters.AddWithValue("@id", id);
            param.Direction = System.Data.ParameterDirection.Input;
            con.Open();
            SqlDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                tmp = r.GetString(0);
            }
            con.Close();
            return tmp;
        }
        public DateTime getDateByIdRepair(int id)
        {
            DateTime date = DateTime.Now;
            com = new SqlCommand("getDateByIdRepair", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter param = com.Parameters.AddWithValue("@id", id);
            param.Direction = System.Data.ParameterDirection.Input;
            con.Open();
            SqlDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                date = r.GetDateTime(0);
            }
            con.Close();
            return date;
        }

        public string getTypeRepairById(int id)
        {
            string type = "";
            com = new SqlCommand("getTypeRepairById", con);
            com.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter param = com.Parameters.AddWithValue("@id", id);
            param.Direction = System.Data.ParameterDirection.Input;

            con.Open();
            SqlDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                type = r.GetString(0);
            }
            con.Close();
            return type;
        }
        public string getEngineerById(int id)
        {
            string engineer = "";
            com = new SqlCommand("getEngineerById", con);
            com.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter param = com.Parameters.AddWithValue("@id", id);
            param.Direction = System.Data.ParameterDirection.Input;

            con.Open();
            SqlDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                engineer = r.GetString(0);
            }
            con.Close();
            return engineer;
        }

        public string getStatusById(int id)
        {
            string status = "";
            com = new SqlCommand("getStatusById", con);
            com.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter param = com.Parameters.AddWithValue("@id", id);
            param.Direction = System.Data.ParameterDirection.Input;

            con.Open();
            SqlDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                status = r.GetString(0);
            }
            con.Close();
            return status;
        }

        public string getNameClientByIdRepair(int id)
        {
            string nameClient = "";
            com = new SqlCommand("getNameClientByIdRepair", con);
            com.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter param = com.Parameters.AddWithValue("@id", id);
            param.Direction = System.Data.ParameterDirection.Input;

            con.Open();
            SqlDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                nameClient = r.GetString(0);
            }
            con.Close();
            return nameClient;
        }

        public void getRepair(int id, Repair repair)
        {
            com = new SqlCommand("getRepair", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter param = com.Parameters.AddWithValue("@id", id);
            param.Direction = System.Data.ParameterDirection.Input;
            con.Open();
            SqlDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                repair.IdRepair = r.GetInt32(0);
                repair.Date = r.GetDateTime(1);
                repair.IdClient = r.GetInt32(2);
                repair.IdModel = r.GetInt32(3);
                repair.SN = r.GetString(4);
                repair.IdType = r.GetInt32(5);
                repair.Defect = r.GetString(6);
                repair.KitView = r.GetString(7);
                repair.IdEngineer = r.GetInt32(8);
                repair.Result = r.GetString(9);
                repair.Price = r.GetInt32(10);
                repair.IdStatus = r.GetInt32(11);
            }
            con.Close();
        }
        public List<Client> getClients()
        {
            List<Client> clients = new List<Client>();
            com = new SqlCommand("getClients", con);
            com.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                Client client = new Client(r.GetInt32(0),
                    r.GetString(1), r.GetString(2), r.GetString(3), r.GetString(4), r.GetString(5));
                clients.Add(client);
            }
            con.Close();
            return clients;
        }

        public void getAllBrendsWithCategories(List<string> brands, List<string> categoriesBrands)
        {
            com = new SqlCommand("getAllBrandsWithCategories", con);
            com.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader r = com.ExecuteReader();

            while (r.Read())
            {
                brands.Add(r.GetString(0));
                categoriesBrands.Add(r.GetString(1));
            }
            con.Close();
        }

        public bool AddCategory(string nameCategory)
        {
            try
            {
                com = new SqlCommand("AddCategory", con);
                com.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter param = com.Parameters.AddWithValue("@name", nameCategory);
                param.Direction = System.Data.ParameterDirection.Input;

                con.Open();
                if (com.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Нет подключения к БД, категория не была добавлена!");
                    return false;
                }

                else
                {
                    return true;
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
            finally
            {
                com.Dispose();
                con.Close();
            }
        }

        public bool AddBrand(string nameBrand, string nameCategory)
        {
            try
            {
                com = new SqlCommand("AddBrand", con);
                com.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter param = com.Parameters.AddWithValue("@nameBrand", nameBrand);
                param.Direction = System.Data.ParameterDirection.Input;

                param = com.Parameters.AddWithValue("@nameCategory", nameCategory);
                param.Direction = System.Data.ParameterDirection.Input;

                con.Open();
                if (com.ExecuteNonQuery() == 0)
                {
                    MessageBox.Show("Нет подключения к БД, бренд не был добавлен!");
                    return false;
                }

                else
                {
                    return true;
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
            finally
            {
                com.Dispose();
                con.Close();
            }
        }

        public void EditCategory(string oldname, string newname)
        {
            com = new SqlCommand("EditCategory", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter param = com.Parameters.AddWithValue("@oldname", oldname);
            param.Direction = System.Data.ParameterDirection.Input;
            param = com.Parameters.AddWithValue("@newname", newname);
            param.Direction = System.Data.ParameterDirection.Input;
            con.Open();
            SqlDataReader r = com.ExecuteReader();
            con.Close();
        }

        public List<string> getBrands()
        {
            List<string> brands = new List<string>();
            com = new SqlCommand("getBrands", con);
            com.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader r = com.ExecuteReader();

            while (r.Read())
            {
                brands.Add(r.GetString(0));
            }
            con.Close();
            return brands;
        }

        public List<string> getBrandsByCategory(string nameCategory)
        {
            List<string> brands = new List<string>();
            com = new SqlCommand("getBrandsByCategory", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter param = com.Parameters.AddWithValue("@nameCategory", nameCategory);
            param.Direction = System.Data.ParameterDirection.Input;
            con.Open();
            SqlDataReader r = com.ExecuteReader();

            while (r.Read())
            {
                brands.Add(r.GetString(0));
            }
            con.Close();
            return brands;
        }

        public List<Model> getModelByCategoryAndBrandAll(string nameCategory, string nameBrand)
        {
            List<Model> models = new List<Model>();
            com = new SqlCommand("getModelByCategoryAndBrandAll", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter param = com.Parameters.AddWithValue("@nameCategory", nameCategory);
            param.Direction = System.Data.ParameterDirection.Input;
            param = com.Parameters.AddWithValue("@nameBrand", nameBrand);
            param.Direction = System.Data.ParameterDirection.Input;
            con.Open();
            SqlDataReader r = com.ExecuteReader();

            while (r.Read())
            {
                Model tmp = new Model();
                tmp.IdModel = r.GetInt32(0);
                tmp.NameModel = r.GetString(1);
                tmp.IdBrand = r.GetInt32(2);
                tmp.IdCategory = r.GetInt32(3);
                models.Add(tmp);
            }
            con.Close();
            return models;
        }

        public List<string> getModelByCategoryAndBrand(string nameCategory, string nameBrand)
        {
            List<string> models = new List<string>();
            com = new SqlCommand("getModelByCategoryAndBrand", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter param = com.Parameters.AddWithValue("@nameCategory", nameCategory);
            param.Direction = System.Data.ParameterDirection.Input;
            param = com.Parameters.AddWithValue("@nameBrand", nameBrand);
            param.Direction = System.Data.ParameterDirection.Input;
            con.Open();
            SqlDataReader r = com.ExecuteReader();

            while (r.Read())
            {
                models.Add(r.GetString(0));
            }
            con.Close();
            return models;
        }

        public List<string> getListString(string nameStoredProcedure)
        {
            List<string> tmp = new List<string>();
            com = new SqlCommand(nameStoredProcedure, con);
            com.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader r = com.ExecuteReader();

            while (r.Read())
            {
                tmp.Add(r.GetString(0));
            }
            con.Close();
            return tmp;
        }

        public List<string> getCategories()
        {
            List<string> categories = new List<string>();
            com = new SqlCommand("getCategories", con);
            com.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader r = com.ExecuteReader();

            while (r.Read())
            {
                categories.Add(r.GetString(0));
            }
            con.Close();
            return categories;
        }

        public List<Category> getCategoriesAll()
        {
            List<Category> categories = new List<Category>();
            com = new SqlCommand("getCategoriesAll", con);
            com.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader r = com.ExecuteReader();

            while (r.Read())
            {
                Category tmp = new Category();
                tmp.IdCategory = r.GetInt32(0);
                tmp.NameCategory = r.GetString(1);
                categories.Add(tmp);
            }
            con.Close();
            return categories;
        }

        public List<Brand> getBrandsByCategoryAll(string nameCategory)
        {
            List<Brand> brands = new List<Brand>();
            com = new SqlCommand("getBrandsByCategoryAll", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlParameter param = com.Parameters.AddWithValue("@nameCategory", nameCategory);
            param.Direction = System.Data.ParameterDirection.Input;
            con.Open();
            SqlDataReader r = com.ExecuteReader();

            while (r.Read())
            {
                Brand tmp = new Brand();
                tmp.IdBrand = r.GetInt32(0);
                tmp.NameBrand = r.GetString(1);
                tmp.IdCategory = r.GetInt32(2);
                brands.Add(tmp);
            }
            con.Close();
            return brands;
        }

        public List<Engineer> getEngineersAll()
        {
            List<Engineer> engineers = new List<Engineer>();
            com = new SqlCommand("getEngineersAll", con);
            com.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader r = com.ExecuteReader();

            while (r.Read())
            {
                Engineer tmp = new Engineer();
                tmp.IdEngineer = r.GetInt32(0);
                tmp.NameEngineer = (r.GetString(1));
                engineers.Add(tmp);
            }
            con.Close();
            return engineers;
        }

        public List<string> getEngineers()
        {
            List<string> engineers = new List<string>();
            com = new SqlCommand("getEngineers", con);
            com.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader r = com.ExecuteReader();

            while (r.Read())
            {
                engineers.Add(r.GetString(0));
            }
            con.Close();
            return engineers;
        }

        public List<StatusRepair> getStatusAll()
        {
            List<StatusRepair> status = new List<StatusRepair>();
            com = new SqlCommand("getStatusAll", con);
            com.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader r = com.ExecuteReader();

            while (r.Read())
            {
                StatusRepair tmp = new StatusRepair();
                tmp.IdRepair = r.GetInt32(0);
                tmp.NameStatus = r.GetString(1);
                status.Add(tmp);
            }
            con.Close();
            return status;
        }

        public List<string> getStatus()
        {
            List<string> status = new List<string>();
            com = new SqlCommand("getStatus", con);
            com.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader r = com.ExecuteReader();

            while (r.Read())
            {
                status.Add(r.GetString(0));
            }
            con.Close();
            return status;
        }

        public List<string> getTypes()
        {
            List<string> types = new List<string>();
            com = new SqlCommand("getTypes", con);
            com.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader r = com.ExecuteReader();

            while (r.Read())
            {
                types.Add(r.GetString(0));
            }
            con.Close();
            return types;
        }

        public List<TypeRepair> getTypesAll()
        {
            List<TypeRepair> types = new List<TypeRepair>();
            com = new SqlCommand("getTypesAll", con);
            com.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader r = com.ExecuteReader();

            while (r.Read())
            {
                TypeRepair tmp = new TypeRepair();
                tmp.IdType = r.GetInt32(0);
                tmp.NameType = r.GetString(1);
                types.Add(tmp);
            }
            con.Close();
            return types;
        }

        public List<RepairView> ShowRepairsNotFinishForDS()//не использую
        {
            List<RepairView> repairsView = new List<RepairView>();
            com = new SqlCommand("ShowRepairsNotFinish", con);
            com.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                RepairView repairView = new RepairView();

                repairView.IdRepair = r.GetInt32(0);
                repairView.Date = r.GetDateTime(1);
                repairView.NameClient = r.GetString(2);
                repairView.Contact = r.GetString(3);
                repairView.Phone = r.GetString(4);
                repairView.Device = r.GetString(5);
                repairView.SN = r.GetString(6);
                repairView.TypeRepair = r.GetString(7);
                repairView.Defect = r.GetString(8);
                repairView.KitView = r.GetString(9);
                repairView.Engineer = r.GetString(10);
                repairView.Result = r.GetString(11);
                repairView.Price = r.GetInt32(12);
                repairView.Status = r.GetString(13);

                repairsView.Add(repairView);
            }
            con.Close();
            return repairsView;
        }
        public List<String[]> ShowRepairsNotFinish()
        {
            List<String[]> rows = new List<string[]>();
            try
            {

                com = new SqlCommand("ShowRepairsNotFinish", con);
                com.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader r = com.ExecuteReader();

                int num = r.FieldCount;

                //     MessageBox.Show(num.ToString(), "Количество столбцов в SqlDataReader ");



                string[] attributes = new string[num];

                for (int i = 0; i < num; i++)
                    attributes[i] = r.GetName(i);


                //    attributes[0] = "Район";


                rows.Add(attributes);//добавили 0 строкой названия столбцов
                string[] row = null;

                while (r.Read())
                {
                    row = new string[num];
                    for (int i = 0; i < num; i++)
                        //  lst.Add(reader.GetString(0));
                        row[i] = r[i].ToString();
                    rows.Add(row);
                }
            }
            catch (SqlException exc)
            {
                MessageBox.Show(exc.Message);

            }
            finally
            {
                com.Dispose();
                con.Close();
            }
            return rows;
        }
        public List<String[]> getRepairByNumber(int id)
        {
            List<String[]> rows = new List<string[]>();
            try
            {

                com = new SqlCommand("getRepairByNumber", con);
                com.CommandType = CommandType.StoredProcedure;
                SqlParameter param = com.Parameters.AddWithValue("@number", id);
                param.Direction = ParameterDirection.Input;
                con.Open();
                SqlDataReader r = com.ExecuteReader();

                int num = r.FieldCount;

                //     MessageBox.Show(num.ToString(), "Количество столбцов в SqlDataReader ");



                string[] attributes = new string[num];

                for (int i = 0; i < num; i++)
                    attributes[i] = r.GetName(i);


                //    attributes[0] = "Район";


                rows.Add(attributes);//добавили 0 строкой названия столбцов
                string[] row = null;

                while (r.Read())
                {
                    row = new string[num];
                    for (int i = 0; i < num; i++)
                        //  lst.Add(reader.GetString(0));
                        row[i] = r[i].ToString();
                    rows.Add(row);
                }
            }
            catch (SqlException exc)
            {
                MessageBox.Show(exc.Message);

            }
            finally
            {
                com.Dispose();
                con.Close();
            }
            return rows;
        }
        public List<String[]> getAllRepairs()
        {
            List<String[]> rows = new List<string[]>();
            try
            {

                com = new SqlCommand("getAllRepairs", con);
                com.CommandType = CommandType.StoredProcedure;
                con.Open();
                SqlDataReader r = com.ExecuteReader();

                int num = r.FieldCount;

                     //MessageBox.Show(num.ToString(), "Количество столбцов в SqlDataReader ");



                string[] attributes = new string[num];

                for (int i = 0; i < num; i++)
                    attributes[i] = r.GetName(i);


                //    attributes[0] = "Район";


                rows.Add(attributes);//добавили 0 строкой названия столбцов
                string[] row = null;

                while (r.Read())
                {
                    row = new string[num];
                    for (int i = 0; i < num; i++)
                        //  lst.Add(reader.GetString(0));
                        row[i] = r[i].ToString();
                    rows.Add(row);
                }
            }
            catch (SqlException exc)
            {
                MessageBox.Show(exc.Message);

            }
            finally
            {
                com.Dispose();
                con.Close();
            }
            return rows;
        }
        public List<String[]> getRepairBySN(string SN)
        {
            List<String[]> rows = new List<string[]>();
            try
            {

                com = new SqlCommand("getRepairBySN", con);
                com.CommandType = CommandType.StoredProcedure;
                SqlParameter param = com.Parameters.AddWithValue("@SN", SN);
                param.Direction = ParameterDirection.Input;
                con.Open();
                SqlDataReader r = com.ExecuteReader();

                int num = r.FieldCount;

                //     MessageBox.Show(num.ToString(), "Количество столбцов в SqlDataReader ");



                string[] attributes = new string[num];

                for (int i = 0; i < num; i++)
                    attributes[i] = r.GetName(i);


                //    attributes[0] = "Район";


                rows.Add(attributes);//добавили 0 строкой названия столбцов
                string[] row = null;

                while (r.Read())
                {
                    row = new string[num];
                    for (int i = 0; i < num; i++)
                        //  lst.Add(reader.GetString(0));
                        row[i] = r[i].ToString();
                    rows.Add(row);
                }
            }
            catch (SqlException exc)
            {
                MessageBox.Show(exc.Message);

            }
            finally
            {
                com.Dispose();
                con.Close();
            }
            return rows;
        }
        public List<String[]> getRepairByOther(string SN)
        {
            List<String[]> rows = new List<string[]>();
            try
            {

                com = new SqlCommand("getRepairByOther", con);
                com.CommandType = CommandType.StoredProcedure;
                SqlParameter param = com.Parameters.AddWithValue("@find", SN);
                param.Direction = ParameterDirection.Input;
                con.Open();
                SqlDataReader r = com.ExecuteReader();

                int num = r.FieldCount;

                //     MessageBox.Show(num.ToString(), "Количество столбцов в SqlDataReader ");



                string[] attributes = new string[num];

                for (int i = 0; i < num; i++)
                    attributes[i] = r.GetName(i);


                //    attributes[0] = "Район";


                rows.Add(attributes);//добавили 0 строкой названия столбцов
                string[] row = null;

                while (r.Read())
                {
                    row = new string[num];
                    for (int i = 0; i < num; i++)
                        //  lst.Add(reader.GetString(0));
                        row[i] = r[i].ToString();
                    rows.Add(row);
                }
            }
            catch (SqlException exc)
            {
                MessageBox.Show(exc.Message);

            }
            finally
            {
                com.Dispose();
                con.Close();
            }
            return rows;
        }
    }
}

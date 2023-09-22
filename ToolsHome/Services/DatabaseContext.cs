using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ToolsHome.Models;
using ToolsHome.Views;

namespace ToolsHome.Services
{
    public class DatabaseContext
    {
        public SQLiteAsyncConnection Connection { get; set; }
        public DatabaseContext(string path) 
        { 
            Connection = new SQLiteAsyncConnection(path);
            Connection.CreateTableAsync<Tarea>().Wait();         
        }
        public  async  Task<List<Tarea>> GetItemsAsynx()
        {
            return await Connection.Table<Tarea>().ToListAsync() ;
        }
        public async Task<int> InsertItemAsync(Tarea item)
        {
            return await Connection.InsertAsync(item);
        }

        public async Task<int> DeleteItemAsync(Tarea item)
        {
            return await Connection.DeleteAsync(item);
        }

    }
}

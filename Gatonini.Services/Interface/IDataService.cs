using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Gatonini.Services
{
    public interface IDataService<T>
    {
        Task<IEnumerable<T>> GetItemsAsync(string token, string url = null);
        Task<List<T[]>> GetItemsGroupedAsync(string token, string url = null);
        Task<T> GetItemAsync(string token, string url = null);
        Task<T> AddAsync(T value, string token, string url = null);
        Task<IEnumerable<T>> AddListAsync(List<T> values, string token, string url = null);
        Task<T> UpdateAsync(T value, string url, string token);
        Task<IEnumerable<T>> UpdateListAsync(List<T> values, string token, string url = null);
        Task<T> DeleteAsync(string token, T value, string url = null);
    }
    public interface IDataService<T, D>
    {
        Task<IEnumerable<T>> GetItemsAsync(string token, string url = null);
        Task<List<T[]>> GetItemsGroupedAsync(string token, string url = null);
        Task<T> GetItemAsync(string token, string url = null);
        Task<T> AddAsync(T value, string token, string url = null);
        Task<IEnumerable<T>> AddListAsync(List<T> values, string token, string url = null);
        Task<T> UpdateAsync(T value, string url, string token);
        Task<IEnumerable<T>> UpdateListAsync(List<T> values, string token, string url = null);
        Task<T> DeleteAsync(string token, T value, string url = null);
        Task<IEnumerable<D>> EditAsync(List<D> values, string token, Guid id, string url = null);
    }
}

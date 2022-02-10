using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MobilneHotel.Views.Klient;
using MobilneHotelServiceReference;
using Xamarin.Forms;

namespace MobilneHotel.Services
{
    public abstract class ItemDataStore<T> : IDataStore<T>
    {
        public IService1 service1;
        public List<T> items { get; set; }

        public ItemDataStore()
        {
            service1 = DependencyService.Get<IService1>();
        }
        public abstract void RefreshList();
        public abstract void Add(T item);
        public abstract void DeleteItem(int item);
        public async Task<bool> AddItemAsync(T item)
        {
            Add(item);
            //items.Add(item);
            return await Task.FromResult(true);
        }
        public async Task<bool> DeleteItemAsync(int id)
        {
            DeleteItem(id);
            //var oldItem = Find(id);
            //items.Remove(oldItem);
            return await Task.FromResult(true);

        }
        public abstract T Find(T item);
        public abstract T Find(int id);

        public async Task<bool> UpdateItemAsync(T item)
        {
            var oldItem = Find(item);
            items.Remove(oldItem);
            items.Add(item);
            return await Task.FromResult(true);
        }
      
        public async Task<T> GetItemAsync(int id)
        {
            return await Task.FromResult(Find(id));
        }
        public async Task<IEnumerable<T>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
       

    }
}

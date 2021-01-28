﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Mine.Models;

namespace Mine.Services
{
    public class MockDataStore : IDataStore<ItemModel>
    {
        readonly List<ItemModel> items;

        public MockDataStore()
        {
            items = new List<ItemModel>()
            {
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "swimsuit", Description="a normal swim suit", Value=6 },
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "swim shorts", Description="swim trunks that will slow you down", Value=3 },
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "swim pants", Description="jeans but for in the pool that make you drown",Value=1 },
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "swim leggings", Description="swim tights that will make you faster",Value=7 },
                new ItemModel { Id = Guid.NewGuid().ToString(), Text = "swim brief", Description="a swimsuit like an underwear", Value=5 },
            };
        }

        public async Task<bool> CreateAsync(ItemModel item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateAsync(ItemModel item)
        {
            var oldItem = items.Where((ItemModel arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteAsync(string id)
        {
            var oldItem = items.Where((ItemModel arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<ItemModel> ReadAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<ItemModel>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}
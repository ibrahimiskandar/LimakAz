﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LimakAz.Models
{
    public class ShopItemsPager
    {
        public int TotalItems { get; private set; }
        public int CurrentPage { get; private set; }
        public int PageSize { get; private set; }
        public int TotalPages { get; private set; }
        public int StartPage { get; private set; }
        public int EndPage { get; private set; }
        public ShopItemsPager()
        {
        }
        public ShopItemsPager(int totalItems, int page, int pageSize=10)
        {
            int totalPages=(int)Math.Ceiling((decimal)totalItems/(decimal)pageSize);
            int curretPage = page;
            int startPage = curretPage - 5;
            int endPage = curretPage+4;
            if (startPage<=0)
            {
                endPage = endPage - (startPage - 1);
                startPage = 1;
            }
            if (endPage>totalPages)
            {
                endPage = totalPages;
                if (endPage>10)
                {
                    startPage = endPage - 9;
                }
            }
            TotalItems = totalItems;
            CurrentPage = curretPage;
            PageSize = pageSize;
            TotalPages = totalPages;
            StartPage = startPage;
            EndPage = endPage;
        }
    }
}

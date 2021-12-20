﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProductReviewManagement
{
    class Management
    {

        public void Display(List<ProductReview> productList)
        {
            foreach (ProductReview pro in productList)
            {
                Console.WriteLine("ProductId : {0} \t UserId : {1} \t Rating : {2} \t Review : {3} \t IsLike : {4}", pro.ProductID, pro.UserID, pro.Rating, pro.Review, pro.IsLike);
            }
        }
        public void TopThreeRatingRecords(List<ProductReview> productList)
        {
            var records = (from Product in productList orderby Product.Rating descending select Product).Take(3).ToList();
            Display(records);
        }
    }
}


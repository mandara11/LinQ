using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Review_Management
{
    public class ProductReviewManagement
    {
        readonly List<ProductReview> ProductReviewsList;

        //UC1:Create product review class with 25 default values
        public ProductReviewManagement()
        {
            ProductReviewsList = new List<ProductReview>();
            {
                new ProductReview() { ProductID = 1, UserID = 1, Rating = 1, Review = "good", IsLike = true};
                new ProductReview() { ProductID = 1, UserID = 1, Rating = 1, Review = "good", IsLike = true};
                new ProductReview() { ProductID = 3, UserID = 2, Rating = 1, Review = "good", IsLike = true};
                new ProductReview() { ProductID = 4, UserID = 2, Rating = 2, Review = "bad", IsLike = false};
                new ProductReview() { ProductID = 5, UserID = 5, Rating = 2, Review = "bad", IsLike = true};
                new ProductReview() { ProductID = 5, UserID = 3, Rating = 2, Review = "good", IsLike = false};
                new ProductReview() { ProductID = 7, UserID = 4, Rating = 3, Review = "bad", IsLike = true};
                new ProductReview() { ProductID = 7, UserID = 4, Rating = 3, Review = "good", IsLike = true};
                new ProductReview() { ProductID = 9, UserID = 6, Rating = 3, Review = "bad", IsLike = false};
                new ProductReview() { ProductID = 10, UserID = 5, Rating = 4, Review = "good", IsLike = false};
                new ProductReview() { ProductID = 10, UserID = 6, Rating = 4, Review = "nice", IsLike = true};
                new ProductReview() { ProductID = 10, UserID = 6, Rating = 4, Review = "bad", IsLike = true};
                new ProductReview() { ProductID = 10, UserID = 7, Rating = 5, Review = "good", IsLike = false};
                new ProductReview() { ProductID = 14, UserID = 7, Rating = 5, Review = "nice", IsLike = false};
                new ProductReview() { ProductID = 15, UserID = 8, Rating = 5, Review = "bad", IsLike = false};
                new ProductReview() { ProductID = 16, UserID = 8, Rating = 1, Review = "good", IsLike = true};
                new ProductReview() { ProductID = 18, UserID = 9, Rating = 1, Review = "good", IsLike = true};
                new ProductReview() { ProductID = 18, UserID = 9, Rating = 1, Review = "verybad", IsLike = false};
                new ProductReview() { ProductID = 19, UserID = 10, Rating = 2, Review = "bad", IsLike = true};
                new ProductReview() { ProductID = 20, UserID = 10, Rating = 3, Review = "good", IsLike = false};
                new ProductReview() { ProductID = 21, UserID = 11, Rating = 2, Review = "average", IsLike = true};
                new ProductReview() { ProductID = 21, UserID = 11, Rating = 3, Review = "bad", IsLike = false};
                new ProductReview() { ProductID = 25, UserID = 12, Rating = 3, Review = "good", IsLike = true};
                new ProductReview() { ProductID = 25, UserID = 12, Rating = 3, Review = "average", IsLike = true};
                new ProductReview() { ProductID = 25, UserID = 12, Rating = 4, Review = "average", IsLike = true};
            };
        }
        public void DisplayProductReviewList(List<ProductReview> productReviewsList)
        {
            foreach (var product in ProductReviewsList)
            {
                Console.WriteLine("Product ID" + ":" + product.ProductID);
                Console.WriteLine("User ID" + ":" + product.UserID);
                Console.WriteLine("Rating" + ":" + product.Rating);
                Console.WriteLine("Review" + ":" + product.Review);
                Console.WriteLine("Liked" + ":" + product.IsLike);
                Console.WriteLine();
            }
        }

        //UC2:Retrives the top3 products by rating.
        public List<ProductReview> RetrieveTop3ByRating(List<ProductReview> productReviewsList)
        {
            return productReviewsList.OrderByDescending(product => product.Rating).Take(3).ToList();
        }

        //UC3:Retrieve all by ratings limit and product ids
        public List<ProductReview> RetrieveAllByRatingLimitAndProductIDS(List<ProductReview> productReviewsList, double Ratings, int[] productIDS)
        {
            return productReviewsList.FindAll(product => productIDS.Contains(product.ProductID))
                .FindAll(product => product.Rating.CompareTo(Ratings) >= 0).ToList();
        }

        //UC4:Retrieves the review count for each product identifiers
        public Dictionary<int, int> RetrieveReviewCountForEachProductID(List<ProductReview> productReviewList)
        {
            return productReviewList.GroupBy(product => product.ProductID).ToDictionary(p => p.Key, p => p.Count());
        }

        //UC5/UC7:Retrieves the product identifier and review.
        public object RetrieveProductIDAndReview(List<ProductReview> productReviewList)
        {
            var p = productReviewList.Select(product => new { ProductID = product.ProductID, Review = product.Review }).ToList();
            return p;
        }

        //UC6:Skip first 5 parameter from the list
        public List<ProductReview> RetrieveProductReviewSkippingTop5(List<ProductReview> productReviewList)
        {
            return productReviewList.Skip(5).ToList();
        }

        //UC8:Creates the data table of product review
        public System.Data.DataTable CreateDataTableOfProductReview(List<ProductReview> productReviewList)
        {
            DataTable ProductReviewDataTable = new DataTable();
            ProductReviewDataTable.Columns.Add("ProductID");
            ProductReviewDataTable.Columns.Add("UserID");
            ProductReviewDataTable.Columns.Add("Rating");
            ProductReviewDataTable.Columns.Add("Review");
            ProductReviewDataTable.Columns.Add("IsLike");

            productReviewList.ForEach(product =>
            {
                ProductReviewDataTable.Rows.Add(product.ProductID);
                ProductReviewDataTable.Rows.Add(product.UserID);
                ProductReviewDataTable.Rows.Add(product.Rating);
                ProductReviewDataTable.Rows.Add(product.Review);
            });
            return ProductReviewDataTable;
        }

        //UC9:
        public DataTable RetrievedetailsWithLikes(DataTable productReviewDataTable)
        {
            DataTable dataTable = new DataTable();
            dataTable = productReviewDataTable.AsEnumerable().Where(product => product.Field<bool>("IsLike").Equals(true)).CopyToDataTable();
            return dataTable;
        }
        public void DisplayDataTable(DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (DataColumn column in dataTable.Columns)
                {
                    Console.WriteLine(row[column]);
                }
            }
        }
        
        //UC10: Retrieves the average rating at each product
        public Dictionary<int, double> RetrieveAverageRatingOfProduct(List<ProductReview> productsReviewList)
        {
            return productsReviewList.GroupBy(product => product.ProductID).ToDictionary(p => p.Key, p => p.Average(p => p.Rating));
        }

        //UC11:Retrieves all product reviews having review nice
        public List<ProductReview> RetrieveAllProductReviewsHavingNice(List<ProductReview> productsReviewList)
        {
            return productsReviewList.FindAll(product => product.Review.Equals("nice", StringComparison.OrdinalIgnoreCase));
        }

        //UC12:Retrieves all the product review by user identifier and order by rating.
        public List<ProductReview> RetrieveAllProductReviews_UserIDAndOrderByRating(List<ProductReview> productsReviewList)
        {
            return productsReviewList.FindAll(product => product.UserID.Equals(userID)).OrderBy(product => product.Rating).ToList();
        }

    }
}

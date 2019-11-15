using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication11.Models;

namespace WebApplication11.DataAccess
{
    public class Initilizer : CreateDatabaseIfNotExists<Context>
    {
        protected override void Seed(Context context)
        {
            var news = new List<Article>
            {
                new Article
                {
                    Title = "Motorola представила складной смартфон Razr",
                    Description = "Motorola представила складной смартфон Razr с сенсорным гибким экраном 6,2 дюйма. Обзор устройства опубликовало The Verge. ",
                    ImagePath = "https://leonardo.osnova.io/bb65d26b-98fc-da71-d76d-0dc6c34c7af9/"
                },
                new Article
                {
                    Title = "AliExpress впервые раскрыл финансовые результаты распродажи «11.11»",
                    Description = "За два дня заказы оформили пять миллионов россиян",
                    ImagePath = "https://cashback2you.ru/wp-content/uploads/2018/08/alibaba.jpg"
                },
                new Article
                {
                    Title ="Facebook представила платёжную систему для соцсети",
                    Description = "Компания Facebook представила Facebook Pay — единую платёжную систему для своих сервисов, которая будет доступна пользователям Facebook, Messenger, Instagram и WhatsApp.",
                    ImagePath = "https://leonardo.osnova.io/cb4e72b6-17ef-6e7d-e7e0-c40bde92ca8d/-/scale_crop/1200x766/center/-/format/webp/"
                }
            };

            context.News.AddRange(news);

            context.Admins.Add(new Admin
            {
                Login = "admin",
                Password = "1234"
            });
            context.SaveChanges();
        }
    }
}
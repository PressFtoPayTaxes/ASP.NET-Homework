using System.Collections.Generic;
using System.Data.Entity;
using WorkWithModel.Models;

namespace WorkWithModel.DataAccess
{
    public class ArticleInitializer : CreateDatabaseIfNotExists<ArticleContext>
    {
        protected override void Seed(ArticleContext context)
        {
            context.News.AddRange(new List<Article>
            {
                new Article
                {
                    Theme = "Киев захотел компенсацию от ЕС в случае снятия санкций с России",
                    Description = "Украина хочет получить компенсацию от Евросоюза в том случае, если ЕС не продлит санкции против России при отсутствии прогресса в реализации Минских соглашений, заявил украинский вице-премьер Дмитрий Кулеба в интервью «РБК-Украина».",
                    ImageSource = "../Images/ukraine-article.jpg"
                },
                new Article
                {
                    Theme = "Виновницу ДТП с российским «пьяным мальчиком» выпустили на свободу",
                    Description = "Ольга Алисова, сбившая в подмосковной Балашихе шестилетнего мальчика, в крови которого обнаружили 2,7 промилле алкоголя, вышла на свободу. Об этом со ссылкой на источник в правоохранительных органах сообщает RT в своем Telegram-канале.",
                    ImageSource = "../Images/alisova-article.jpg"
                },
                new Article
                {
                    Theme = "В Greenpeace предложили запретить влажные салфетки в России",
                    Description = "Greenpeace предлагает запретить использование в России основных 10 одноразовых пластиковых загрязнителей окружающей среды, в том числе влажных салфеток, говорится в письме российского отделения организации на имя главы Минприроды Дмитрия Кобылкина.",
                    ImageSource = "../Images/napkin-article.jpg"
                }
            });

            context.SaveChanges();
        }
    }
}
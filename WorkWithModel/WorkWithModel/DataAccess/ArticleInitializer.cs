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
                    ImageSource = "~/Images/ukraine-article.jpg"
                }
            });
        }
    }
}
using System.Linq;
using Ymagazin.Models;

namespace Ymagazin
{
    public class SampleData
    {
        public static void Initialize(Context context)
        {
            if (!context.Clients.Any())
            {
                context.Clients.AddRange(
                    new Client
                    {
                        FIO_clienta = "Пылькин Владимир Алексеевич",
                        Telefon_clienta = "88005553535",
                    },
                    new Client
                    {
                        FIO_clienta = "Вышиков Пётр Константинович",
                        Telefon_clienta = "89005553999",
                    },
                    new Client
                    {
                        FIO_clienta = "Туриков Дмитрий Харитонов",
                        Telefon_clienta = "88777777777",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
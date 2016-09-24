using System;

namespace prog03
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Для начало введите имя");
			String name = Console.ReadLine();
			Console.WriteLine("Здравствуй " + name + "!");
			Console.WriteLine("Данна программа предназначана для игры в загадки, вам задают загадку а вы пишите на неё ответ");
			Console.WriteLine("Для продалжения нажмите ENTER");
			Console.ReadLine();
			Console.WriteLine("Загадка №1");
			Console.WriteLine("Сверху черно внутри красно, как засунешь так прекрасно.");
			String zag1 = Console.ReadLine();
			if (zag1 == "Галоши" || zag1 == "галоши") {
				Console.WriteLine("Верно!");
			} else {
				Console.WriteLine("Неверно!");
			}
			Console.WriteLine("Для продалжения нажмите ENTER");
			Console.ReadLine();
			Console.WriteLine("Загадка №2");
			Console.WriteLine("Туда - сюда - обратно, тебе и мне приятно.");
			String zag2 = Console.ReadLine();
			if (zag2 == "Качели" || zag2 == "качели") {
				Console.WriteLine("Верно!");
			} else {
				Console.WriteLine("Неверно!");
			}
			Console.WriteLine("Для продалжения нажмите ENTER");
			Console.ReadLine();
			Console.WriteLine("Загадка №3");
			Console.WriteLine("Красная головка в дырку лезет ловко.");
			String zag3 = Console.ReadLine();
			if (zag3 == "Дятел" || zag3 == "дятел") {
				Console.WriteLine("Верно!");
			} else {
				Console.WriteLine("Неверно!");
			}
			Console.WriteLine("Для продалжения нажмите ENTER");
			Console.ReadLine();
			Console.WriteLine("Загадка №4");
			Console.WriteLine("Ты помни его немножко, станет твердым как картошка.");
			String zag4 = Console.ReadLine();
			if (zag4 == "Снежок" || zag4 == "снежок") {
				Console.WriteLine("Верно!");
			} else {
				Console.WriteLine("Неверно!");
			}
			Console.WriteLine("Для продалжения нажмите ENTER");
			Console.ReadLine();
			Console.WriteLine("Загадка №5");
			Console.WriteLine("Не xpен, не морковка - красная головка.");
			String zag5 = Console.ReadLine();
			if (zag5 == "Пионер в пилотке" || zag5 == "пионер в пилотке" || zag5 == "Пионер в Пилотке" || zag5 == "Пионер В Пилотке") {
				Console.WriteLine("Верно!");
			} else {
				Console.WriteLine("Неверно!");
			}
			Console.WriteLine("Для продалжения нажмите ENTER");
			Console.ReadLine();
			Console.WriteLine("Загадка №6");
			Console.WriteLine("Возьму его в руки, Сожму его крепко - Он станет упругим и твердым, как репка.");
			String zag6 = Console.ReadLine();
			if (zag6 == "Снежок" || zag6 == "снежок") {
				Console.WriteLine("Верно!");
			} else {
				Console.WriteLine("Неверно!");
			}
			Console.WriteLine("Для продалжения нажмите ENTER");
			Console.ReadLine();
			Console.WriteLine("Загадка №7");
			Console.WriteLine("Волос на волос, тело на тело и начинается темное дело.");
			String zag7 = Console.ReadLine();
			if (zag7 == "Веки" || zag7 == "веки") {
				Console.WriteLine("Верно!");
			} else {
				Console.WriteLine("Неверно!");
			}
			Console.WriteLine("Для продалжения нажмите ENTER");
			Console.ReadLine();
			Console.WriteLine("Загадка №8");
			Console.WriteLine("Лежит на спине - никому не нужна. Прислони к стене - пригодится она.");
			String zag8 = Console.ReadLine();
			if (zag8 == "Лестница" || zag8 == "лестница") {
				Console.WriteLine("Верно!");
			} else {
				Console.WriteLine("Неверно!");
			}
			Console.WriteLine("Для продалжения нажмите ENTER");
			Console.ReadLine();
			Console.WriteLine("Загадка №9");
			Console.WriteLine("Кругом волоса, посредине колбаса.");
			String zag9 = Console.ReadLine();
			if (zag9 == "Кукуруза" || zag9 == "кукуруза") {
				Console.WriteLine("Верно!");
			} else {
				Console.WriteLine("Неверно!");
			}
			Console.WriteLine("Для продалжения нажмите ENTER");
			Console.ReadLine();
			Console.WriteLine("Загадка №10");
			Console.WriteLine("Чтобы спереди погладить, нужно сзади полизать.");
			String zag10 = Console.ReadLine();
			if (zag10 == "Почтовая марка" || zag10 == "почтовая марка" || zag10 == "Марка" || zag10 == "марка") {
				Console.WriteLine("Верно!");
			} else {
				Console.WriteLine("Неверно!");
			}
			Console.WriteLine("Для продалжения нажмите ENTER");
			Console.ReadLine();
			Console.WriteLine("На этом программа заканчивается спасибо и удачи вам "+ name + "!");
			Console.WriteLine("Всего самого наилучшего!");
			
			Console.WriteLine("Разработчик Сидоров Алексей");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}
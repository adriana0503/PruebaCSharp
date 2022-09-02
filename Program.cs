int respuesta;
Console.WriteLine("diga su nombre");
String nombre=Console.ReadLine();
do
{
       Console.WriteLine("diga su genero musical favorito");
	Console.WriteLine("1.bachata");
	Console.WriteLine("2.merengue");
	Console.WriteLine("3.reggeton");
	Console.WriteLine("4.pop");
	Console.WriteLine("5.vallenato");
	Console.WriteLine("6:no te gusta ninguna");
	Console.WriteLine("7:te gustan todas");
	Console.WriteLine("8:salir");
        respuesta=Convert.ToInt32(Console.ReadLine());
 
 switch (respuesta)
 {
       case 1:
       Console.WriteLine(nombre + " te gusta la bachata");
       break;

	case 2:
       Console.WriteLine(nombre + " te gusta el merengue");
       break;

	case 3:
       Console.WriteLine(nombre + " te gusta la reggeton");
       break;

	case 4:
       Console.WriteLine(nombre + " te gusta el pop");
       break;

	case 5:
       Console.WriteLine(nombre + " te gusta el vallenato");
       break;

	case 6:
       Console.WriteLine(nombre + " no te gusta ningun genero de los que aparecen");
       break;

	case 7:
       Console.WriteLine(nombre + " te gustan todos los generos de esta lista");
       break;

	case 8:
       Console.WriteLine(nombre + " usted salio");
       break;

       default:   
      Console.WriteLine("eso no esta entre las opciones");
      break;
 }
} while (respuesta != 8);
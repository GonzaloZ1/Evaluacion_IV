using Evaluacion_IV.Models;

Console.WriteLine("Evaluación IV");
Console.WriteLine("========================================");

using (EFContext bd = new EFContext())
{
    /* 0) Mostrar todos los estudios
    var todosEstudios = bd.Estudios.ToList();
    Console.WriteLine("Nombre | Fundación | Consola | Empleados");
    Console.WriteLine("========================================");
    foreach (var estudio in todosEstudios)
    {
        Console.WriteLine(estudio.Nombre + " | " + estudio.Fundacion + " | " + estudio.Consola + " | " + estudio.Empleados);
    }
    */
    
    /* 0) Mostrar todos los Juegos
    var todosJuegos = bd.Juegos.ToList();
    Console.WriteLine("Estudio ID | Nombre | Unidades Vendidas");
    Console.WriteLine("========================================");
    foreach (var juego in todosJuegos)
    {
        Console.WriteLine(juego.EstudioId + " | " + juego.Nombre + " | " + juego.UnidadesVendidas);
    }
    */
    
    /* 1) Mostrar todos los registros de la tabla 1 que posea
          dos condiciones a través de AND, ordenada descendentemente
          por algún campo numérico o de texto.
          (Para una mejor demostración, probar despues de hacer la inserción "4)")
                
    var mostrarEstudios = bd.Estudios
        .Where(x => x.Empleados > 500 && x.Consola == true)
        .OrderBy(x => x.Empleados)
        .ToList();
    Console.WriteLine("Nombre | Fundación | Consola | Empleados");
    foreach (var estudio in mostrarEstudios)
    {
        Console.WriteLine(estudio.Nombre + " | " + estudio.Fundacion + " | " + estudio.Consola + " | " + estudio.Empleados);
    }
    */
    

    /* 2) Obtener un promedio numérico desde la columna de alguna tabla.

    double promedio = bd.Juegos.Average(x => x.UnidadesVendidas);
    Console.WriteLine("El promedio de unidades vendidas es: " + promedio);
    */
    
    /* 3) Mostrar el primer registro desde un rango de fecha de la columna date/datetime en la tabla 1.

    DateOnly min = bd.Estudios.Min(x => x.Fundacion);
    var primeraFecha = bd.Estudios.First(x => x.Fundacion == min);
    Console.WriteLine("Nombre | Fundación | Consola | Empleados");
    Console.WriteLine(primeraFecha.Nombre + " | " + primeraFecha.Fundacion + " | " + primeraFecha.Consola + " | " + primeraFecha.Empleados);
    */
    
    /* 4) Insertar un nuevo registro para la tabla 1
    Estudio nuevoEstudio = new Estudio();
    nuevoEstudio.Nombre = "xbox";
    nuevoEstudio.Fundacion = new DateOnly(2000, 03, 01);
    nuevoEstudio.Consola = true;
    nuevoEstudio.Empleados = null;
    
    bd.Estudios.Add(nuevoEstudio);
    bd.SaveChanges();
    */
    
    /* 5) Demuestre la actualización de dos campos en alguna tabla.
          (Para realizar la demostración, probar despues de hacer la inserción "4)")
     
    var estudioEditar = bd.Estudios.FirstOrDefault(x => x.Id == 4);

    estudioEditar.Nombre = "Xbox";
    estudioEditar.Empleados = 500;
    bd.Estudios.Update(estudioEditar);
    bd.SaveChanges();
    */
    
    /* 6) Demuestre la eliminación de un registro de la tabla 2.
     
    var juegoEliminar = bd.Juegos.FirstOrDefault(x => x.Id == 1);
    bd.Juegos.Remove(juegoEliminar);
    bd.SaveChanges();
    */
}
using Newtonsoft.Json;

namespace ProyectoExamenU2POO.Database
{
    public class ProyectoExamenSeeder
    {
        public static async Task LoadDataAsync(ProyectoExamenContext context, ILoggerFactory loggerFactory)
        {
            try
            {
              //  await LoadTableAsync(loggerFactory, context);
               
            }
            catch (Exception e)
            {
                var logger = loggerFactory.CreateLogger<ProyectoExamenSeeder>();
                logger.LogError(e, "Error inicializando la data del API.");
            }

        }

        //public static async Task LoadCategoriesAsync(ILoggerFactory loggerFactory, BlogUNAHContext context)
        //{
        //    try
        //    {
        //        var jsonFilePath = "SeedData/categories.json";
        //        var jsonContent = await File.ReadAllTextAsync(jsonFilePath); // Lee el contenido completo del archivo JSON y lo almacena en 'jsonContent'.
        //        var categories = JsonConvert.DeserializeObject<List<CategoryEntity>>(jsonContent);
        //        // Deserializa el contenido JSON (jsonContent) en una lista de objetos 'CategoryEntity'. Cada objeto 'CategoryEntity' representa una categoría del blog.
        //        if (!await context.Categories.AnyAsync()) // Verifica si la tabla de categorías está vacía en la base de datos. retorna 'true' si la tabla tiene algún registro y 'false' si está vacía.
        //        {
        //            for (int i = 0; i < categories.Count; i++) // actualiza propiedades de auditoría
        //            {
        //                categories[i].CreatedBy = "bcf446b1-700a-4478-bd5f-f0539c89d8e8";
        //                categories[i].CreatedDate = DateTime.Now;
        //                categories[i].UpdatedBy = "bcf446b1-700a-4478-bd5f-f0539c89d8e8";
        //                categories[i].UpdatedDate = DateTime.Now;
        //            }

        //            context.AddRange(categories); //  los está marcando para inyectar en la dataBase
        //            await context.SaveChangesAsync(); // Guarda los cambios ya en la base de datos
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        var logger = loggerFactory.CreateLogger<BlogUNAHContext>();
        //        logger.LogError(e, "Error al ejecutar el Seed de categorias.");
        //    }
        //}

    }
}

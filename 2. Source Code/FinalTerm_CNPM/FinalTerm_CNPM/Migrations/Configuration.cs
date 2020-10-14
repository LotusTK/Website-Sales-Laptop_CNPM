namespace FinalTerm_CNPM.Migrations
{
    using FinalTerm_CNPM.Models;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<FinalTerm_CNPM.Models.FinalTermContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(FinalTerm_CNPM.Models.FinalTermContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            IList<Cpu> cpus = new List<Cpu>();
            cpus.Add(new Cpu() 
            { 
                nameCpu = "Intel Core i3 Ice Lake", 
                typeCpu = "Intel Core i3", 
                detailCpu = "Loại CPU: 1005G1;Tốc độ CPU: 1.20 GHz;Tốc độ tối đa: Turbo Boost 3.4 GHz" 
            });
            cpus.Add(new Cpu()
            {
                nameCpu = "Intel Core i7 Comet Lake",
                typeCpu = "Intel Core i7",
                detailCpu = "Loại CPU: 10750H;Tốc độ CPU 2.60 GHz;Tốc độ tối đa:Turbo Boost 5.0 GHz"
            });
            cpus.Add(new Cpu() 
            { 
                nameCpu = "AMD Ryzen 7",
                typeCpu = "Ryzen 7",
                detailCpu = "Loại CPU:4800HS;Tốc độ CPU:2.90 GHz;Tốc độ tối đa:Turbo Boost 4.2 GHz"
            });
            context.Cpus.AddRange(cpus);

            IList<Ram> rams = new List<Ram>();
            rams.Add(new Ram() 
            {
                nameRam = "RAM Laptop Samsung 16GB DDR4",
                typeRam = "DDR4",
                sizeRam = 16,
                unitSizeRam = "GB",
                busRam = "2666MHz"
            });
            rams.Add(new Ram()
            {
                nameRam = "RAM Laptop 8GB DDR4",
                typeRam = "DDR3",
                sizeRam = 8,
                unitSizeRam = "GB",
                busRam = "1600MHz"
            });
            rams.Add(new Ram()
            {
                nameRam = "RAM Laptop Samsung 4GB DDR4",
                typeRam = "DDR4",
                sizeRam = 4,
                unitSizeRam = "GB",
                busRam = "2400MHz"
            });
            context.Rams.AddRange(rams);

            IList<Storage> storages = new List<Storage>();
            storages.Add(new Storage() 
            { 
                nameStorage = "Ổ Cứng SSD M.2 KingSpec NGFF 2280",
                typeStorage = "SSD",
                sizeStorage = 512,
                unitSizeStorage = "GB",
                detailStorage = "Kết nối: NGFF(M.2)"
            });
            storages.Add(new Storage()
            {
                nameStorage = "Ổ Cứng SSD KingSpec",
                typeStorage = "SSD",
                sizeStorage = 128,
                unitSizeStorage = "GB",
                detailStorage = "Kết nối: NGFF(M.2)"
            });
            storages.Add(new Storage()
            {
                nameStorage = "Ổ Cứng HDD Laptop",
                typeStorage = "HDD",
                sizeStorage = 1,
                unitSizeStorage = "TB",
                detailStorage = "Kết nối: SATA II"
            });
            context.Storages.AddRange(storages);

            IList<Laptop> laptops = new List<Laptop>();
            laptops.Add(new Laptop() 
            { 
                nameLaptop = "Laptop 01",
                displaySize = "15.6 inch",
                weightLaptop = 2.7,
                detailLaptop = "Laptop thử nghiệm 01"
            });
            laptops.Add(new Laptop()
            {
                nameLaptop = "Laptop 02",
                displaySize = "13.3 inch",
                weightLaptop = 1.3,
                detailLaptop = "Laptop thử nghiệm 02"
            });
            laptops.Add(new Laptop()
            {
                nameLaptop = "Laptop 03",
                displaySize = "14 inch",
                weightLaptop = 1.5,
                detailLaptop = "Laptop thử nghiệm 03"
            });
            context.Laptops.AddRange(laptops);

            IList<Product> products = new List<Product>();
            products.Add(new Product() 
            {
                state = 0,
                price = 20000000,
                primaryType = "laptop",
                img = "",
                laptopId = 1,
                cpuId = 1,
                ramId = 2,
                storageId = 3
            });
            products.Add(new Product()
            {
                state = 0,
                price = 15000000,
                primaryType = "laptop",
                img = "",
                laptopId = 3,
                cpuId = 3,
                ramId = 1,
                storageId = 1
            });
            products.Add(new Product()
            {
                state = 0,
                price = 25000000,
                primaryType = "laptop",
                img = "",
                laptopId = 2,
                cpuId = 2,
                ramId = 1,
                storageId = 1
            });

            base.Seed(context);
        }
    }
}

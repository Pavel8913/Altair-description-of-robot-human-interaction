


using System.Diagnostics;

string vibor;
vvod_raket();
Console.ReadLine();
void vvod_raket()
{    
    string NI = "Научно-исследовательская";    
    string GRUS = "Грузовая";
    string TRANS = "Транспортная";
    //Console.WriteLine("Выберите тип ракеты: ");
    Console.WriteLine("Выберите тип ракеты: "+'\n'+"1) " + NI+'\n'+ "2) "+GRUS+'\n'+"3)"+TRANS);
    vibor = Console.ReadLine();
    if (vibor == "1")
    {
        NI_raketa nI_Raketa = new NI_raketa();
        Console.WriteLine("Вы выбрали Научно-исследовательскую ракету");
        nI_Raketa.vvod_dalnost();
    }
    else if (vibor=="2")
    {
        Grus_raketa grus_Raketa=new Grus_raketa();
        Console.WriteLine("Вы выбрали грузовую ракету");
        grus_Raketa .vvod_dalnost();
    }
    else if(vibor=="3")
    {
        Console.WriteLine("Вы выбрали транспортную ракету");
        trans_raketa trans_Raketa = new trans_raketa();
        trans_Raketa.vvod_dalnost();
    }
    
    else
    {
        Console.WriteLine("Неверный ввод!");
        vvod_raket();
    }
}



public class NI_raketa
{
    string dalnost;
    public void vvod_dalnost()
    {

        Console.WriteLine('\n' + "Выберите дальность ракеты: " + '\n' + "1) Малая" + '\n' + "2)Средняя" + '\n' + "3)Большая");
        dalnost = Console.ReadLine();
        if (dalnost == "1")
        {
            NI_raketa ni_raketa = new NI_raketa();
            NI_raketa_maloiy_dalnosti ni_NI_raketa_mal = new NI_raketa_maloiy_dalnosti();
            Console.WriteLine("Вы выбрали малую дальность");
            ni_NI_raketa_mal.proverka();
        }
        else if (dalnost == "2")
        {
            Console.WriteLine("Вы выбрали среднюю дальность");            
            NI_raketa_sredney_dalnosti ni_NI_raketa_sred = new NI_raketa_sredney_dalnosti();
            ni_NI_raketa_sred.proverka();

        }
        else if (dalnost == "3")
        {
            Console.WriteLine("Вы выбрали большую дальность");
            NI_raketa_bolshoy_dalnosti ni_NI_raketa_bol = new NI_raketa_bolshoy_dalnosti();
            ni_NI_raketa_bol.proverka();
        }
        else
        {
            Console.WriteLine("Неверный ввод!");
            vvod_dalnost();
        }
    }


    public class NI_raketa_maloiy_dalnosti 
    {
        Cklad cklad = new Cklad();
        int odin_uskoritel = 1;
        int nauch_modul = 1;
        int stabilisator = 1;
        int modul_svasi = 1;
        int modul_yprav_poletom = 1;
        int obekatel = 1;

        public void proverka()
        {
            if(odin_uskoritel<=cklad.odin_uskoritel&&nauch_modul <= cklad.nauch_modul&&stabilisator <= cklad.stabilisator&&modul_svasi <= cklad.modul_svasi&&modul_yprav_poletom <= cklad.modul_yprav_poletom&&obekatel <= cklad.obekatel)
            {
                Console.WriteLine("Сборка завершена!");
            }
            else
            {
                Console.WriteLine("Не хватает копонентов");
            }
        }
          
    }
                 
    
    public class NI_raketa_sredney_dalnosti
    {
            Cklad cklad = new Cklad();
            int dvoynoy_uskoritel=1;
            int odin_uskoritel = 1;
            int nauch_modul = 1;
            int stabilisator = 1;
            int modul_svasi = 1;
            int modul_yprav_poletom = 1;
            int obekatel = 1;

        public void proverka()
        {
            if (odin_uskoritel<=cklad.odin_uskoritel&& dvoynoy_uskoritel <= cklad.dvoynoy_uskoritel && nauch_modul <= cklad.nauch_modul && stabilisator <= cklad.stabilisator && modul_svasi <= cklad.modul_svasi && modul_yprav_poletom <= cklad.modul_yprav_poletom && obekatel <= cklad.obekatel)
            {
                Console.WriteLine("Сборка завершена!");
            }
            else
            {
                Console.WriteLine("Не хватает копонентов");
            }
        }


    }
    public class NI_raketa_bolshoy_dalnosti
    {
            Cklad cklad = new Cklad();
            int dvoynoy_uskoritel = 2;
            int odin_uskoritel = 1;
            int nauch_modul = 1;
            int stabilisator = 1;
            int modul_svasi = 1;
            int modul_yprav_poletom = 1;
            int obekatel = 1;

        public void proverka()
        {
            if (odin_uskoritel <= cklad.odin_uskoritel && dvoynoy_uskoritel <= cklad.dvoynoy_uskoritel && nauch_modul <= cklad.nauch_modul && stabilisator <= cklad.stabilisator && modul_svasi <= cklad.modul_svasi && modul_yprav_poletom <= cklad.modul_yprav_poletom && obekatel <= cklad.obekatel)
            {
                Console.WriteLine("Сборка завершена!");
            }
            else
            {
                Console.WriteLine("Не хватает копонентов");
            }
        }


    }
}

public class Grus_raketa
{
    string dalnost;
    public void vvod_dalnost()
    {

        Console.WriteLine('\n' + "Выберите дальность ракеты: " + '\n' + "1) Малая" + '\n' + "2)Средняя" + '\n' + "3)Большая");
        dalnost = Console.ReadLine();
        if (dalnost == "1")
        {
            Grus_raketa_mal_dal grus_Raketa_Mal_Dal=new Grus_raketa_mal_dal();
            Console.WriteLine("Вы выбрали малую дальность");
            grus_Raketa_Mal_Dal.proverka();
        }
        else if (dalnost == "2")
        {
            Console.WriteLine("Вы выбрали среднюю дальность");
            Grus_raketa_sred_dal grus_Raketa_Sred_Dal=new Grus_raketa_sred_dal();
            grus_Raketa_Sred_Dal.proverka();

        }
        else if (dalnost == "3")
        {
            Console.WriteLine("Вы выбрали большую дальность");
            Grus_raketa_bol_dal grus_Raketa_bol_dal=new Grus_raketa_bol_dal();
            grus_Raketa_bol_dal.proverka();
        }
        else
        {
            Console.WriteLine("Неверный ввод!");
            vvod_dalnost();
        }
    }

    public class Grus_raketa_mal_dal
    {
        Cklad cklad = new Cklad();
        int odin_uskoritel = 1;
        int dvoynoy_uskoritel = 1;
        int modul_grus = 1;
        int stabilisator = 1;
        int modul_svasi = 1;
        int modul_yprav_poletom = 1;
        int obekatel = 1;

        public void proverka()
        {
            if (dvoynoy_uskoritel <= cklad.dvoynoy_uskoritel && odin_uskoritel <= cklad.odin_uskoritel && modul_grus <= cklad.modul_grusovoy && stabilisator <= cklad.stabilisator && modul_svasi <= cklad.modul_svasi && modul_yprav_poletom <= cklad.modul_yprav_poletom && obekatel <= cklad.obekatel)
            {
                Console.WriteLine("Сборка завершена!");
            }
            else
            {
                Console.WriteLine("Не хватает копонентов");
            }
        }
    }

    public class Grus_raketa_sred_dal
    {
        Cklad cklad = new Cklad();
        int dvoynoy_uskoritel = 1;
        int odin_uskoritel = 1;
        int modul_grus = 3;
        int stabilisator = 1;
        int modul_svasi = 1;
        int modul_yprav_poletom = 1;
        int obekatel = 1;

        public void proverka()
        {
            if (odin_uskoritel <= cklad.odin_uskoritel &&dvoynoy_uskoritel<=cklad.dvoynoy_uskoritel&& modul_grus <= cklad.modul_grusovoy && stabilisator <= cklad.stabilisator && modul_svasi <= cklad.modul_svasi && modul_yprav_poletom <= cklad.modul_yprav_poletom && obekatel <= cklad.obekatel)
            {
                Console.WriteLine("Сборка завершена!");
            }
            else
            {
                Console.WriteLine("Не хватает копонентов");
            }
        }
    }

    
    
    public class Grus_raketa_bol_dal
    {
        Cklad cklad = new Cklad();
        int dvoynoy_uskoritel = 2;
        int odin_uskoritel = 1;
        int modul_grus = 5;
        int stabilisator = 1;
        int modul_svasi = 1;
        int modul_yprav_poletom = 1;
        int obekatel = 1;

        public void proverka()
        {
            if (odin_uskoritel <= cklad.odin_uskoritel && dvoynoy_uskoritel <= cklad.dvoynoy_uskoritel && modul_grus <= cklad.modul_grusovoy && stabilisator <= cklad.stabilisator && modul_svasi <= cklad.modul_svasi && modul_yprav_poletom <= cklad.modul_yprav_poletom && obekatel <= cklad.obekatel)
            {
                Console.WriteLine("Сборка завершена!");
            }
            else
            {
                Console.WriteLine("Не хватает копонентов");
            }
        }
    }

}

public class trans_raketa
{
    string dalnost;
    public void vvod_dalnost()
    {

        Console.WriteLine('\n' + "Выберите дальность ракеты: " + '\n' + "1) Малая" + '\n' + "2)Средняя" + '\n' + "3)Большая");
        dalnost = Console.ReadLine();
        if (dalnost == "1")
        {
            Console.WriteLine("Вы выбрали малую дальность");
            trans_raketa_mal_dal trans_Raketa_Mal_Dal = new trans_raketa_mal_dal();
            trans_Raketa_Mal_Dal.proverka();
        }
        else if (dalnost == "2")
        {
            Console.WriteLine("Вы выбрали среднюю дальность");
            trans_raketa_sred_dal trans_Raketa_Sred_dal=new trans_raketa_sred_dal();
            trans_Raketa_Sred_dal.proverka();

        }
        else if (dalnost == "3")
        {
            Console.WriteLine("Вы выбрали большую дальность");
            trans_raketa_bol_dal trans_Raketa_bol_dal=new trans_raketa_bol_dal();
            trans_Raketa_bol_dal.proverka();
        }
        else
        {
            Console.WriteLine("Неверный ввод!");
            vvod_dalnost();
        }
    }

    public class trans_raketa_mal_dal
    {
        Cklad cklad = new Cklad();        
        int odin_uskoritel = 1;
        int modul_grus = 1;
        int stabilisator = 1;
        int modul_svasi = 1;
        int modul_life = 1;
        int obekatel = 1;

        public void proverka()
        {
            if (odin_uskoritel <= cklad.odin_uskoritel &&  modul_grus <= cklad.modul_grusovoy && stabilisator <= cklad.stabilisator && modul_svasi <= cklad.modul_svasi && modul_life <= cklad.modul_life && obekatel <= cklad.obekatel)
            {
                Console.WriteLine("Сборка завершена!");
            }
            else
            {
                Console.WriteLine("Не хватает копонентов");
            }
        }
    }

    public class trans_raketa_sred_dal
    {
        Cklad cklad = new Cklad();
        int odin_uskoritel = 1;
        int dvoynoy_uskoritel = 1;
        int modul_grus = 1;
        int stabilisator = 1;
        int modul_svasi = 1;
        int modul_life = 1;
        int obekatel = 1;

        public void proverka()
        {
            if (odin_uskoritel <= cklad.odin_uskoritel && dvoynoy_uskoritel<=cklad.dvoynoy_uskoritel&& modul_grus <= cklad.modul_grusovoy && stabilisator <= cklad.stabilisator && modul_svasi <= cklad.modul_svasi && modul_life <= cklad.modul_life && obekatel <= cklad.obekatel)
            {
                Console.WriteLine("Сборка завершена!");
            }
            else
            {
                Console.WriteLine("Не хватает копонентов");
            }
        }
    }

    public class trans_raketa_bol_dal
    {
        Cklad cklad = new Cklad();
        int odin_uskoritel = 1;
        int dvoynoy_uskoritel = 2;
        int modul_yprav = 1;
        int modul_grus = 1;
        int stabilisator = 1;
        int modul_svasi = 1;
        int modul_life = 1;
        int obekatel = 1;

        public void proverka()
        {
            if (odin_uskoritel <= cklad.odin_uskoritel && dvoynoy_uskoritel <= cklad.dvoynoy_uskoritel && modul_yprav<=cklad.modul_yprav_poletom&& modul_grus <= cklad.modul_grusovoy && stabilisator <= cklad.stabilisator && modul_svasi <= cklad.modul_svasi && modul_life <= cklad.modul_life && obekatel <= cklad.obekatel)
            {
                Console.WriteLine("Сборка завершена!");
            }
            else
            {
                Console.WriteLine("Не хватает копонентов");
            }
        }
    }
}
    public class Cklad
    {   
        public int odin_uskoritel = 6;
        public int nauch_modul = 2;
        public int stabilisator = 4;
        public int modul_svasi = 10;
        public int modul_yprav_poletom = 4;
        public int obekatel = 12;
        public int dvoynoy_uskoritel = 3;
        public int modul_life = 3;
        public int modul_grusovoy = 4;

    }

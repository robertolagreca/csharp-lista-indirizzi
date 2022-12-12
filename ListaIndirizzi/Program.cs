// See https://aka.ms/new-console-template for more information

//In questo esercizio dovrete leggere un file CSV, che cambia poco da quanto appena visto nel live-coding in
//classe, e salvare tutti gli indirizzi contenuti al sul interno all’interno di una lista di oggetti istanziati a
//partire dalla classe Indirizzo.

//Attenzione: gli ultimi 3 indirizzi presentano dei possibili “casi particolari” che possono accadere a questo
//genere di file: vi chiedo di pensarci e di gestire come meglio crediate queste casistiche.

using ListaIndirizzi;

StreamReader file;
string line, name, surname, address, city, province, zip;



List<DataUser> dataList = new List<DataUser>();

file = File.OpenText("C:\\Users\\robsm\\Documents\\Generation Coding\\Dotnet\\ListaIndirizzi\\ListaIndirizzi\\File\\addresses.csv");

line = file.ReadLine(); //Legge qui la prima linea. Posso usare anche un contatore in alternativa e gli dico
                        //di non prendere la riga 0.

while (!file.EndOfStream)
{
    line = file.ReadLine();


    string[] singleData = line.Split(",");

//AVVISO
//formattazione del csv, in modo che se ci fossero dati mancanti lascia il vuoto.

//if (singleData.Length == 6)
//Se metto qua il tutto mi toglie quelli che non arrivano a 6 campi
//{ }

   /* name = singleData[0];
    surname = singleData[1];
    address = singleData[2];
    city = singleData[3];
    province = singleData[4];
    zip = singleData[5]; */

//ciclo for
 for(int i = 0; i < singleData.Length; i++)
    {
        if (singleData[i] == "")
        {
            singleData[i] = "Campo mancante";
        }
    }

DataUser dataRow = new DataUser(singleData[0], singleData[1], singleData[2], singleData[3], singleData[4], singleData[5]);

 //DataUser dataRow = new DataUser(name, surname, address, city, province, zip);

    dataList.Add(dataRow);


}

file.Close();


foreach (DataUser data in dataList)
{
    Console.WriteLine(data);
    //Console.WriteLine(data.GetName());
    Console.WriteLine(Environment.NewLine);

}


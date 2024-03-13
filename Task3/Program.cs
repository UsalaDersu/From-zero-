/* Скорость лодки в стоячей воде V км/ч, скорость течения реки U км/ч (U < V). 
Время движения лодки по озеру T1 ч, а по реке (против течения) — T2 ч. 
Определить путь S, пройденный лодкой.  */

double V = 2;
double U = 1;
double T1 = 3;
double T2 = 0.5;
double SLake = V * T1;
double SRiver = (V - U) * T2;
double S = SLake + SRiver;
System.Console.WriteLine($"Путь по озеру: {SLake}, Путь по реке: {SRiver = (V-U)*T2}, Пройденный путь: {S}");

// See https://aka.ms/new-console-template for more information

int soT1 = 0;
int soT2 = 1;
int max = int.Parse(Console.ReadLine());
if (soT1 <= max) Console.Write(soT1 + " ");
if (soT2 <= max) Console.Write(soT2 + " ");
int sotieptheo = soT1 + soT2;
while (sotieptheo < max)
{
    soT1 = soT2;
    soT2 = sotieptheo;
    sotieptheo = soT1 +  soT2;
    Console.Write(soT2 + " ");
}
using System;
using System.Runtime.InteropServices;

namespace forNumber2
{
    /*
     * Члены класса Point: поля – координаты точки; виртуальный метод Display() для
     * вывода характеристик фигуры (объекта); виртуальное свойство Area для получения площади фигуры (объекта).
     * (Явно определенный конструктор отсутствует.)
       
     */
    public class Point 

    {
    public double X { get; set; }
    public double Y { get; set; }
    public virtual double Area { get; }
    public virtual double Perimeter { get; }

    public virtual string Display()
    {
        return $"X = {X:f3}, Y = {Y:f3}";
    }

    
    }
}

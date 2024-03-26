# Lab 5 Exercise 6

## Method with parameter 


1. สร้าง console application project

```
dotnet new console --name Lab05_Ex06
```
2. เปลี่ยน code ให้เป็นดังต่อไปนี้

```cs
var mc = new MyClass();
mc.DisplayParam(3, 4);
class MyClass
{
    public void DisplayParam(int a, int b)
    {
        System.Console.WriteLine($"a = {a}, b = {b}");
    } 
}
```

3. Build project โดยการใช้คำสั่ง

```
dotnet build  Lab05_Ex06
```

4. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 3 ![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-05/assets/144195611/764c7e97-4f09-4124-a6be-555530148edd)


5. Run project โดยการใช้คำสั่ง

```
dotnet run --project Lab05_Ex06
```

6. บันทึกผลที่ได้จากการรันคำสั่งในข้อ 5 ![image](https://github.com/65030121natthamon/03376836-OOP-2566-Lab-05/assets/144195611/849573ec-298c-49fb-a746-4c53cc87a623)



7. อธิบายสิ่งที่พบในการทดลอง
   - สร้างobject ของคลาส MyClassและเรียกใช้ method DisplayParam(int a,int b) จะได้ค่า a=3 b=4 ตามลำดับ


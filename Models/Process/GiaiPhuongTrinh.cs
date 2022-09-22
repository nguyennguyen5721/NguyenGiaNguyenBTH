namespace NguyenGiaNguyenBTH.Models.Process
{
    public class GiaiPhuongTrinh
    {
        //Các bước khai báo 1 phương thức
        //1. Xác định kiểu dữ liệu trả về của phương thức 
        //2. Xác định các tham số đầu vào của phương thức
        //3 Xây dựng phần thân phương thức 
        //4. Trả về dữ liệu tương ứng
        //Xây dựng phương thức tính tổng 2 số nguyên
        public int SumInt(int a ,int b)
        {
            return (a+b );

        }
        //Xây dựng phương thức giải phương trình bậc nhất
        public string GiaiPhuongTrinhBacNhat(double heSoA, double heSoB)
        {
                String message = "";
                double x;
                if(heSoA==0)
                {
                    if(heSoB==0){
                        message = "Phương trình có vô số nghiệm";
                    }
                    else {
                        message = "Phương trình vô nghiệm";
                    }
                }else{
                    x = -heSoB/heSoA;
                    message = " Phương trình có nghiệm x = " + x ;
                }
                return message;
        }
        public string GiaiPhuongTrinhBacHai(double heSoA, double heSoB,double heSoC)
    {
         //khai bao 1 bien  de chua du lieu
        string message = "";
        //khai bao 1 bien so de chua gia tri
        double x;
        double x1;
        double x2;
        double delta;
        delta = heSoB * heSoB - 4 * heSoA * heSoC ;
        if(heSoA==0)
        { x = (double)-heSoC/heSoB;
            //Giai pt bac 1
            if(heSoB ==0)
            {
                //Neu b= 0 vaf c=0 thif phuowng trinh vo so nghiem
                if(heSoC==0)
            {
                message ="Phuong trinh co vo so nghiem";
            }
            //neu b=0 va c!=0 thì vo nghiem
            else{
                message = "phuong trinh vo nghiem";
            }
            }
            else 
            {
                x1=(double)-heSoC/heSoB;
                message ="Phuong trinh co nghiem duy nhat: x={0}";
            }
            return message;
         }
        //Neu a!=0 thif bat dau bac 2
        else
        {
            // tinh delta
               delta = Math.Pow(heSoB, 2) - 4 * heSoA * heSoC;
               //Kiem tra xem <0 thif pt vo nghiem
               if(delta < 0)
               {
                message = "Phuong trinh vo nghiem.";
               }
               //neu delta = 0 thif cos nghiem kep
               else if(delta ==0)
               {
                x1=x2=-heSoB/(2*heSoA);
                message = "Phuong trinh co nghiem kep x= ";
               }
               //neu >0 thif cos nghiem phan biet
               else{
                    x1 = (-heSoB + Math.Sqrt(delta)) / (2 * heSoA);
                    x2 = (-heSoB - Math.Sqrt(delta)) / (2 * heSoA);
                    message = "Phuong trinh co 2 nghiem phan biet:";
                    message = " Nghiem x1=" +x1;
                    message = " Nghiem x2=" +x2;
               }
        }
    
        return message;
    }
        
        
    }
}
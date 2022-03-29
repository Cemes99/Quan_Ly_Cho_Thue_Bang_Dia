
using Project.Models;
using System;
using System.Collections.Generic;

class Db
{
    public static List<MemberModel> listMember = new List<MemberModel>()
    {
        new MemberModel("mem1", "Hanh", "0123456789", "120888999", "Cau Giay, Ha Noi"),
        new MemberModel("mem2", "Luu", "0123456789", "125111222", "Hoa Lac, Ha Noi"),
        new MemberModel("mem3", "Dac", "0123456789", "111888999", "Long Biên, Hà Nội"),
        new MemberModel("mem4", "Name 4", "0123456789", "111888999", "Nam Tu Liem, Ha Noi"),
        new MemberModel("mem5", "Name 5", "0123456789", "111888999", "Tp. Bắc Ninh, Bắc Ninh"),
    };

    public static List<EmployeeModel> listEmp = new List<EmployeeModel>()
    {
        new EmployeeModel("emp1", "emp1", "123456", "0123456789", "Cau Giay, Ha Noi"),
        new EmployeeModel("emp2", "emp2", "123456", "0123456789", "Hoa Lac, Ha Noi"),
        new EmployeeModel("emp3", "emp3", "123456", "0123456789", "Long Bien, Ha Noi"),
    };

    public static List<DiskModel> listDisk = new List<DiskModel>()
    {
        new DiskModel("disk1", "Disk No 1", "Cate 1", "Chưa sử dụng", "Cty A", "Ghi chu"),
        new DiskModel("disk2", "Disk", "Cate 1", "Đã hỏng", "Cty A", "Ghi chu"),
        new DiskModel("disk3", "Disk 3", "Cate 2", "Chưa sử dụng", "Cty A", "Ghi chu"),
        new DiskModel("disk4", "Disk 4", "Cate 2", "Đang được thuê", "Cty A", "Khách thuê Hanh"),
        new DiskModel("disk5", "Disk No 5", "Cate 3", "Chưa sử dụng", "Cty A", "Ghi chú này rất dài nên nội dung sẽ được hiển thị trên nhiều dòng nếu chương trình chạy đúng"),
        new DiskModel("disk6", "Disk 6", "Cate 1", "Đã hỏng", "Cty B", "Ghi chu"),
        new DiskModel("disk7", "Disk 7", "Cate 3", "Chưa sử dụng", "Cty B", "Ghi chu"),
        new DiskModel("disk8", "Disk Number 8", "Cate 2", "Chưa sử dụng", "Cty B", ""),
    };

    public static List<BillModel> listBill = new List<BillModel>()
    {
        new BillModel("bill1", new DateTime(2021, 01, 25) ,"mem1", new List<BillDetails>(){
            new BillDetails(listDisk[0], 30, 100000),
            new BillDetails(listDisk[4], 45, 100000),
            new BillDetails(listDisk[7], 15, 50000),
        }),
        new BillModel("bill2", new DateTime(2022, 01, 25) ,"mem1", new List<BillDetails>(){
            new BillDetails(listDisk[0], 30, 100000),
            new BillDetails(listDisk[4], 45, 100000),
            new BillDetails(listDisk[7], 15, 50000),
        }),
        new BillModel("bill3", new DateTime(2022, 03, 30) ,"mem2", new List<BillDetails>(){
            new BillDetails(listDisk[0], 30, 100000),
            new BillDetails(listDisk[4], 45, 100000),
            new BillDetails(listDisk[7], 15, 50000),
        }),
        new BillModel("bill4", new DateTime(2022, 01, 25) ,"mem3", new List<BillDetails>(){
            new BillDetails(listDisk[0], 30, 100000),
            new BillDetails(listDisk[4], 45, 100000),
            new BillDetails(listDisk[7], 15, 50000),
        }),
                                       
    };
}
/*create database LapTop;
use laptop;*/
------------- Table ---------------

/*==============================================================*/
/* Table: TAIKHOAN                 		                        */
/*==============================================================*/
create table TAIKHOAN
(
   TENDANGNHAP          varchar(10) not null,
   MATKHAU              varchar(20),
   primary key (TENDANGNHAP)
);

insert into TAIKHOAN values
('admin', '1'),
('linda', '1'),
('honghai', '1'),
('thetun','1'),
('vanduc','1');

/*==============================================================*/
/* Table: NHANVIEN                                        */
/*==============================================================*/
create table NHANVIEN
(
   MANV                 char(6) not null,
   TENDANGNHAP          varchar(10) not null,
   TENNV                varchar(50),
   NGAYSINH             date,
   GIOITINH             char(5),
   CHUCVU               varchar(10),
   DIACHI               varchar(100),
   NGAYVL               date,
   SODT                 char(10),
   primary key (MANV)
);

/*==============================================================*/
/* Table: KHACHHANG                                       */
/*==============================================================*/
create table KHACHHANG
(
   MAKH                 char(6) not null,
   TENDANGNHAP          varchar(10) not null,
   TENKH                varchar(50),
   SODT                 char(10),
   EMAIL                varchar(30),
   GIOITINH             char(5),
   primary key (MAKH)
);

insert into KhachHang values
('KH01','linda','Nguyen Linh','0398667273','ailinhvn123@gmail.com','Nu'),
('KH02','honghai','Nguyen Hai','0876543964','honghaivn123@gmail.com','Nu'),
('KH03','thetun','Phan Tuan','0398643573','thetunvn123@gmail.com','Nu'),
('KH04','vanduc','Nguyen Duc','0364567677','vanducvn123@gmail.com','Nu');

/*==============================================================*/
/* Table: SANPHAM                                               */
/*==============================================================*/
create table SANPHAM
(
   MASP                 char(6) not null,
   MADM                 char(6) not null,
   TENSP                varchar(50),
   SOLUONG              int,
   MAUSAC               varchar(20),
   CPU                  varchar(20),
   GPU                  varchar(20),
   RAM                  varchar(20),
   ROM                  varchar(20),
   HOTRORAM             varchar(20),
   RAMTOIDA             varchar(20),
   MANHINH              varchar(20),
   DOPHANGIAI           varchar(20),
   AMTHANH              varchar(20),
   KETNOI               varchar(20),
   WEBCAM               varchar(20),
   KICHTHUOC            varchar(20),
   PIN                  varchar(20),
   MOTA                 varchar(100),
   DONGIA               int,
   img text DEFAULT NULL,
   primary key (MASP)
);

/*==============================================================*/
/* Table: SUKIEN                                          */
/*==============================================================*/
create table SUKIEN
(
   MASK                 char(6) not null,
   TENSK                varchar(50),
   PHANTRAMGIAMGIA      int,
   NGAYBD               date,
   NGAYKT               date,
   primary key (MASK)
);


/*==============================================================*/
/* Table: DANHMUCSANPHAM                                  */
/*==============================================================*/
create table DANHMUCSANPHAM
(
   MADM                 char(6) not null,
   TENDM                varchar(50),
   primary key (MADM)
);

/*==============================================================*/
/* Table:HOADON                                          */
/*==============================================================*/
create table HOADON
(
   MAHD                 char(6) not null,
   MAKH                 char(6) not null,
   MANV                 char(6) not null,
   MASK                 char(6),
   NGAYHD               date,
   DIACHIGIAOHANG       varchar(100),
   TONGTIEN             int,
   THANHTIEN            int,
   primary key (MAHD)
);

/*==============================================================*/
/* Table: CTHD                                            */
/*==============================================================*/
create table CTHD
(
   MAHD                 char(6) not null,
   MASP                 char(6) not null,
   SOLUONG              int,
   primary key (MAHD, MASP)
);

------------------------- FOREIGN KEY --------------------------------
alter table CTHD add constraint FK_CTHD foreign key (MAHD)
      references HOADON (MAHD) on delete restrict on update restrict;

alter table CTHD add constraint FK_CTHD2 foreign key (MASP)
      references SANPHAM (MASP) on delete restrict on update restrict;

alter table HOADON add constraint FK_HD_SK foreign key (MASK)
      references SUKIEN (MASK) on delete restrict on update restrict;

alter table HOADON add constraint FK_LAP foreign key (MANV)
      references NHANVIEN (MANV) on delete restrict on update restrict;

alter table HOADON add constraint FK_THUOC foreign key (MAKH)
      references KHACHHANG (MAKH) on delete restrict on update restrict;

alter table KHACHHANG add constraint FK_CO2 foreign key (TENDANGNHAP)
      references TAIKHOAN (TENDANGNHAP) on delete restrict on update restrict;

alter table NHANVIEN add constraint FK_CO1 foreign key (TENDANGNHAP)
      references TAIKHOAN (TENDANGNHAP) on delete restrict on update restrict;

alter table SANPHAM add constraint FK_THUOC1 foreign key (MADM)
      references DANHMUCSANPHAM (MADM) on delete restrict on update restrict;




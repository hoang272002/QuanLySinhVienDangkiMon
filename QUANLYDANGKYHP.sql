--alter session set "_ORACLE_SCRIPT"=true;
/*drop table sinhvienhcmus;
drop table monhochcmus;
drop table phieudkhp;
drop table ctphieudk;
drop table hoadon;
/
create table sinhvienHCMUS(
    maSV varchar2(10) primary key,
    tenSV varchar2(50),
    ngaySinh date,
    DiaChi varchar2(50),
    sdt varchar2(50),
    pass varchar2(50)
);

create table MonHocHcmus(
    maMH varchar2(10) primary key,
    tenMH varchar2(50),
    soTC int,
    giaTien int
);

create table PhieuDKHP(
    maHP varchar2(10) primary key,
    masv varchar2(10)
);

create table CTPhieuDK(
    maHP varchar2(10),
    maMH varchar2(10),
    soLuong int,
    primary key(maHP,maMH)
);

create table hoadon(
    maHD varchar2(10) primary key,
    maHP varchar2(10),
    TongTien int,
    phuongThuc varchar2(10)
);



ALTER TABLE PhieuDKHP
ADD FOREIGN KEY (maSV) REFERENCES sinhvienHCMUS(maSV);

ALTER TABLE CTPhieuDK
ADD FOREIGN KEY (maHP) REFERENCES PhieuDKHP(maHP);

ALTER TABLE CTPhieuDK
ADD FOREIGN KEY (maMH) REFERENCES MonHocHcmus(maMH);

ALTER TABLE hoadon
ADD FOREIGN KEY (maHP) REFERENCES phieudkhp(maHP);

insert into sinhvienhcmus values ('SV001','Pham Viet Hoang',TO_DATE('2/7/2002','DD/MM/YYYY'),'12 Pham Van Chieu','123456','123');

insert into monhochcmus values ('CSDL','Co so du lieu',4,4600000);
insert into monhochcmus values ('CSDLNC','Co so du lieu nang cao',4,4600000);
insert into monhochcmus values ('HTDN','He thong doanh nghiep HTTT',4,4600000);
insert into monhochcmus values ('PTTK','Phan tich thiet ke HTTT',4,4600000);
insert into monhochcmus values ('ATBM','An toan bao mat',4,4600000);
insert into monhochcmus values ('HQT','He quan tri csdl',4,4600000);
insert into monhochcmus values ('TD','The duc',2,1040000);
insert into monhochcmus values ('MAC','Chinh tri mac-lenin',2,1040000);

insert into PhieuDKHP values ('HP01','SV001');

insert into Hoadon values ('HD01','HP01',null,null);


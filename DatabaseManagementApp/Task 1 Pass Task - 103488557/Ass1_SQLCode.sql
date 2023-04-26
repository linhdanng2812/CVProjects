/* Student Name: Nguyen Linh Dan
   Student ID: 103488557 */

--PART 1--

--PART 1.1--
--2/4 exception--
create or replace procedure ADD_CUST_TO_DB (pcustid NUMBER, pcustname VARCHAR2) AS
    outside_range EXCEPTION;
begin
    if pcustid < 1 or pcustid > 499 then
        raise outside_range;
    end if;
    insert into CUSTOMER (custid, custname, sales_ytd, status)
    values (pcustid, pcustname, 0, 'OK');
exception
    when DUP_VAL_ON_INDEX then
        raise_application_error(-20013, 'Duplicate customer ID');
    when outside_range then
        raise_application_error(-20023, 'Customer ID out of range');
    when others then
        raise_application_error(-20000, SQLERRM);
end;

/

create or replace procedure ADD_CUSTOMER_VIASQLDEV (pcustid number, pcustname varchar2) as
begin
    dbms_output.put_line('--------------------------------------------');
    dbms_output.put_line('Adding Customer. ID: ' || pcustid || '  Name: ' || pcustname);
    ADD_CUST_TO_DB(pcustid, pcustname);
    dbms_output.put_line('Customer Added OK');
    commit;
exception
    when others then
        dbms_output.put_line(sqlerrm);
end;

/

--PART 1.2--
-- 3/3--
create or replace function DELETE_ALL_CUSTOMERS_FROM_DB return number as
begin
    delete from CUSTOMER;
    return SQL%ROWCOUNT;
exception
    when others then
        raise_application_error(-20000, sqlerrm);
end;

/

create or replace procedure DELETE_ALL_CUSTOMERS_VIASQLDEV as
    deletedRowCount number;
begin
    dbms_output.put_line('--------------------------------------------');
    dbms_output.put_line('Deleting all Customer rows');
    deletedRowCount := DELETE_ALL_CUSTOMERS_FROM_DB;
    dbms_output.put_line(deletedRowCount || ' rows deleted');
    commit;
exception
    when others then
        dbms_output.put_line(sqlerrm);
end;

/

--PART 1.3--
--2/4 exception--
create or replace procedure ADD_PRODUCT_TO_DB (pprodid number, pprodname varchar2, pprice number) as
    id_outside_range EXCEPTION;
    price_outside_range EXCEPTION;
begin
    if pprodid < 1000 or pprodid > 2500 then
        raise id_outside_range;
    end if; 
    if pprice < 0 or pprice > 999.99 then
        raise price_outside_range;
    end if;
    
    insert into PRODUCT (prodid, prodname, selling_price, sales_ytd)
    values (pprodid, pprodname, pprice, 0);
exception
    when DUP_VAL_ON_INDEX then
        raise_application_error(-20033, 'Duplicate product ID');
    when id_outside_range then
        raise_application_error(-20047, 'Product ID out of range');
    when price_outside_range then
        raise_application_error(-20051, 'Price out of range');
    when others then
        raise_application_error(-20000, SQLERRM);
end;

/

create or replace procedure ADD_PRODUCT_VIASQLDEV (pprodid number, pprodname varchar2, pprice number) as
begin
    dbms_output.put_line('--------------------------------------------');
    dbms_output.put_line('Adding Product. ID: ' || pprodid || ' Name: ' || pprodname || ' Price: ' || pprice);
    ADD_PRODUCT_TO_DB(pprodid, pprodname, pprice);
    dbms_output.put_line('Product Added OK');
    commit;
exception
    when others then
        dbms_output.put_line(sqlerrm); 
end;

/

--3/3--
create or replace function DELETE_ALL_PRODUCTS_FROM_DB return number as
begin
    delete from PRODUCT;
    return SQL%ROWCOUNT;
exception
    when others then
        raise_application_error(-20000, sqlerrm);
end;

/

create or replace procedure DELETE_ALL_PRODUCTS_VIASQLDEV  as
    deletedRowCount number;
begin
    dbms_output.put_line('--------------------------------------------');
    dbms_output.put_line('Deleting all Product rows');
    deletedRowCount := DELETE_ALL_PRODUCTS_FROM_DB;
    dbms_output.put_line(deletedRowCount || ' rows deleted');
    commit;
exception
    when others then
        dbms_output.put_line(sqlerrm);
end;

/

--PART 1.4--
--2/3 exception--
create or replace function GET_CUST_STRING_FROM_DB (pcustid number) return varchar2 as
    custString varchar2(100) := '';
    pcustname varchar2(100);
    psales_ytd number;
    pstatus varchar2(7);
begin
    select custname, sales_ytd, status into pcustname, psales_ytd, pstatus
    from CUSTOMER
    where pcustid = custid;
    custString := custString || 'Custid: ' || pcustid || ' Name: ' || pcustname || ' Status: '|| pstatus || ' SalesYTD: '|| psales_ytd;
    return custString;
exception
    when no_data_found then
        raise_application_error(-20063, 'Customer ID not found');
    when others then
        raise_application_error(-20000, SQLERRM);
end;

/

create or replace procedure GET_CUST_STRING_VIASQLDEV (pcustid number) as
    custString varchar(100);
begin
    dbms_output.put_line('--------------------------------------------');
    dbms_output.put_line('Getting Details for CustId ' || pcustid);
    custString := GET_CUST_STRING_FROM_DB(pcustid);
    dbms_output.put_line(custString);
exception
    when others then
        dbms_output.put_line(SQLERRM);
end;

/

--2/3--
create or replace procedure UPD_CUST_SALESYTD_IN_DB (pcustid number, pamt number) as
    pamt_out_range exception;
    no_update exception;
begin
    if pamt < -999.99 or pamt > 999.99 then
        raise pamt_out_range;
    end if;
    
    update CUSTOMER
    set sales_ytd = sales_ytd + pamt
    where custid = pcustid;
    
    if SQL%NOTFOUND then
        raise no_update;
    end if;
exception
    when no_update then
        raise_application_error(-20073, 'Customer ID not found');
    when pamt_out_range then
        raise_application_error(-20087, 'Amount out of range');
    when others then
        raise_application_error(-20000, SQLERRM);
end;

/

create or replace procedure UPD_CUST_SALESYTD_VIASQLDEV (pcustid number, pamt number) as
begin
    dbms_output.put_line('--------------------------------------------');
    dbms_output.put_line('Updating SalesYTD. Customer Id: ' || pcustid || ' Amount: ' || pamt);
    UPD_CUST_SALESYTD_IN_DB(pcustid, pamt);
    dbms_output.put_line('Update OK');
    commit;
exception
    when others then
        dbms_output.put_line(SQLERRM);
end;

/

--PART 1.5--
--2/3 not raise expected exception--
create or replace function GET_PROD_STRING_FROM_DB (pprodid number) return varchar2 as
    prodString varchar2(100) := '';
    pprodname varchar2(100);
    psellingprice number;
    psales_ytd number;
begin
    select prodname, selling_price, sales_ytd into pprodname, psellingprice, psales_ytd
    from PRODUCT
    where pprodid = prodid;
    prodString := prodString || 'Prodid: ' || pprodid || ' Name: ' || pprodname || ' Price: '|| psellingprice || ' SalesYTD: '|| psales_ytd;
    return prodString;
exception
    when no_data_found then
        raise_application_error(-20093, 'Product ID not found');
    when others then
        raise_application_error(-20000, SQLERRM);
end;

/

create or replace procedure GET_PROD_STRING_VIASQLDEV (pprodid number) as
    prodString varchar(100);
begin
    dbms_output.put_line('--------------------------------------------');
    dbms_output.put_line('Getting Details for Prod Id  ' || pprodid);
    prodString := GET_PROD_STRING_FROM_DB(pprodid);
    dbms_output.put_line(prodString);
exception
    when others then
        dbms_output.put_line(SQLERRM);
end;

/

--2/3 exception--
create or replace procedure UPD_PROD_SALESYTD_IN_DB (pprodid number, pamt number) as
    pamt_out_range exception;
    no_update exception;
begin
    if pamt < -999.99 or pamt > 999.99 then
        raise pamt_out_range;
    end if;
    
    update PRODUCT
    set sales_ytd = sales_ytd + pamt
    where prodid = pprodid;
    
    if SQL%NOTFOUND then
        raise no_update;
    end if;
exception
    when no_update then
        raise_application_error(-20103, 'Product ID not found');
    when pamt_out_range then
        raise_application_error(-20117, 'Amount out of range');
    when others then
        raise_application_error(-20000, SQLERRM);
end;

/

create or replace procedure UPD_PROD_SALESYTD_VIASQLDEV (pprodid number, pamt number) as
begin
    dbms_output.put_line('--------------------------------------------');
    dbms_output.put_line('Updating SalesYTD. Product Id: ' || pprodid || ' Amount: ' || pamt);
    UPD_PROD_SALESYTD_IN_DB(pprodid, pamt);
    dbms_output.put_line('Update OK');
    commit;
exception
    when others then
        dbms_output.put_line(SQLERRM);
end;

/

--PART 1.6--
--2/4 exception--
create or replace procedure UPD_CUST_STATUS_IN_DB (pcustid number, pstatus varchar2) as
    invalid_status exception;
    no_update exception;
begin
    if LOWER(pstatus) != 'ok' AND LOWER(pstatus) != 'suspend' then
        raise invalid_status;
    end if;
    
    update CUSTOMER
    set status = pstatus
    where pcustid = custid;
    if SQL%NOTFOUND then
        raise no_update;
    end if;
exception
    when no_update then
        raise_application_error(-20123, 'Customer ID not found');
    when invalid_status then
        raise_application_error(-20137, 'Invalid Status value');
    when others then
        raise_application_error(-20000, SQLERRM);
end;

/

create or replace procedure UPD_CUST_STATUS_VIASQLDEV (pcustid number, pstatus varchar2) as
begin
    dbms_output.put_line('--------------------------------------------');
    dbms_output.put_line('Updating Status. Id: ' || pcustid || ' New Status: ' || pstatus);
    UPD_CUST_STATUS_IN_DB(pcustid, pstatus);
    dbms_output.put_line('Update OK');
    commit;
exception
    when others then
        dbms_output.put_line(SQLERRM);
end;

/

--PART 1.7--
--2/4 exception--
create or replace procedure ADD_SIMPLE_SALE_TO_DB (pcustid number, pprodid number, pqty number) as
    qty_out_range exception;
    invalid_status exception;
    no_customer exception;
    no_product exception;
    pcustsales number;
    pprodsales number;
    pstatus varchar(7);
    psellprice number;
begin
    if pqty < 1 or pqty > 999 then
        raise qty_out_range;
    end if;
    select sales_ytd, status into pcustsales, pstatus
    from CUSTOMER where pcustid = custid;

    if LOWER(pstatus) != 'ok' then
        raise invalid_status;
    end if;
    
    select selling_price, sales_ytd into psellprice, pprodsales
    from PRODUCT where prodid = pprodid;
   
    if SQL%NOTFOUND then
        if pcustsales is null then
            raise no_customer;
        end if;
        if pprodsales is null then
            raise no_product;
        end if;
    end if;
    
    update CUSTOMER
    set sales_ytd = pcustsales + (pqty * psellprice)
    where custid = pcustid;
    
    update PRODUCT
    set sales_ytd = pprodsales + (pqty * psellprice)
    where prodid = pprodid;
exception
    when qty_out_range then
        raise_application_error(-20143, 'Sale Quantity outside valid range');
    when invalid_status then
        raise_application_error(-20157, 'Customer status is not OK');
    when no_product then
        raise_application_error(-20175, 'Product ID not found');
    when no_customer then
        raise_application_error(-20161, 'Customer ID not found');
    when others then
        raise_application_error(-20000, SQLERRM);
end;
    
/

create or replace procedure ADD_SIMPLE_SALE_VIASQLDEV (pcustid number, pprodid number, pqty number) as
begin
    dbms_output.put_line('--------------------------------------------');
    dbms_output.put_line('Adding Simple Sale. Cust Id: ' || pcustid || ' Prod Id: ' || pprodid || ' Qty: ' || pqty);
    ADD_SIMPLE_SALE_TO_DB(pcustid, pprodid, pqty);
    dbms_output.put_line('Added Simple Sale OK');
    commit;
exception
    when others then
        dbms_output.put_line(sqlerrm);
end;

/

--PART 1.8--
--3/3--
create or replace function SUM_CUST_SALESYTD return number as
    vSum number;
begin
    select sum(sales_ytd) into vSum
    from CUSTOMER;
    return vSum;
exception
    when others then
        raise_application_error(-20000, SQLERRM);
end;

/

create or replace procedure SUM_CUST_SALES_VIASQLDEV as
    vSum number;
begin
    vSum := SUM_CUST_SALESYTD;
    dbms_output.put_line('--------------------------------------------');
    dbms_output.put_line('Summing Customer SalesYTD');
    dbms_output.put_line('All Customer Total: ' || vSum);
    commit;
exception
    when no_data_found then
        dbms_output.put_line('All Customer Total: 0');
    when others then
        dbms_output.put_line(sqlerrm);
end;

/

--3/3--
create or replace function SUM_PROD_SALESYTD_FROM_DB return number as
    vSum number;
begin
    select sum(sales_ytd) into vSum
    from PRODUCT;
    return vSum;
exception
    when others then
        raise_application_error(-20000, SQLERRM);
end;

/

create or replace procedure SUM_PROD_SALES_VIASQLDEV as
    vSum number;
begin
    vSum := SUM_PROD_SALESYTD_FROM_DB;
    dbms_output.put_line('--------------------------------------------');
    dbms_output.put_line('Summing Product SalesYTD');
    dbms_output.put_line('All Product Total: ' || vSum);
    commit;
exception
    when no_data_found then
        dbms_output.put_line('All Product Total: 0');
    when others then
        dbms_output.put_line(sqlerrm);
end;

/

--PART 2 - FULL MARK 3/3--

--PART 2.1--
create or replace function GET_ALLCUST return SYS_REFCURSOR as
    vCursor SYS_REFCURSOR;
begin
    open vCursor for select * from CUSTOMER;
    return vCursor;
exception
    when others then
        raise_application_error(-20000, SQLERRM);
end;
    
/

create or replace procedure GET_ALLCUST_VIASQLDEV as
    vCursor SYS_REFCURSOR;
    vRecord CUSTOMER%ROWTYPE;
begin
    dbms_output.put_line('--------------------------------------------');
    dbms_output.put_line('Listing All Customer Details');
    vCursor := GET_ALLCUST;
    if vCursor%NOTFOUND then 
        dbms_output.put_line('No rows found');
    end if;
    
    loop
        fetch vCursor into vRecord;
        exit when vCursor%NOTFOUND;
        dbms_output.put_line('Custid: ' || vRecord.custid || ' Name: ' || vRecord.custname || ' Status: ' || vRecord.status || ' SalesYTD: ' || vRecord.sales_ytd);
    end loop;
    close vCursor;
    
    commit;
exception
    when others then
        dbms_output.put_line(sqlerrm);
end;

/

create or replace function GET_ALLPROD_FROM_DB return SYS_REFCURSOR as
    vCursor SYS_REFCURSOR;
begin
    open vCursor for select * from PRODUCT;
    return vCursor;
exception
    when others then
        raise_application_error(-20000, SQLERRM);
end;

/

create or replace procedure GET_ALLPROD_VIASQLDEV as
    vCursor SYS_REFCURSOR;
    vRecord PRODUCT%ROWTYPE;
begin
    dbms_output.put_line('--------------------------------------------');
    dbms_output.put_line('Listing All Product Details');
    vCursor := GET_ALLPROD_FROM_DB;
    if vCursor%NOTFOUND then 
        dbms_output.put_line('No rows found');
    end if;
    
    loop
        fetch vCursor into vRecord;
        exit when vCursor%NOTFOUND;
        dbms_output.put_line('Prodid: ' || vRecord.prodid || ' Name: ' || vRecord.prodname || ' Price: ' || vRecord.selling_price || ' SalesYTD: ' || vRecord.sales_ytd);
    end loop;
    close vCursor;
    
    commit;
exception
    when others then
        dbms_output.put_line(sqlerrm);
end;

/

-- PART 3 --

--PART 3.1--
--2/5 exception--
create or replace procedure ADD_LOCATION_TO_DB (ploccode varchar2, pminqty number, pmaxqty number) as
    CHECK_LOCID_LENGTH exception;
    CHECK_MINQTY_RANGE exception;
    CHECK_MAXQTY_RANGE exception;
    CHECK_MAXQTY_GREATER_MIXQTY exception;
begin
    if length(ploccode) != 5 then
        raise CHECK_LOCID_LENGTH;
    end if;
    if pminqty < 0 or pminqty > 999 then
        raise CHECK_MINQTY_RANGE;
    end if;
    if pmaxqty < 0 or pmaxqty > 999 then
        raise CHECK_MAXQTY_RANGE;
    end if;
    if pmaxqty < pminqty then
        raise CHECK_MAXQTY_GREATER_MIXQTY;
    end if;

    insert into LOCATION (locid, minqty, maxqty) values (ploccode, pminqty, pmaxqty);
exception
    when DUP_VAL_ON_INDEX then
        raise_application_error(-20183, 'Duplicate location ID');
    when CHECK_LOCID_LENGTH then
        raise_application_error(-20197, 'Location Code length invalid');
    when CHECK_MINQTY_RANGE then
        raise_application_error(-20201, 'Minimum Qty out of range');
    when CHECK_MAXQTY_RANGE then
        raise_application_error(-20215, 'Maximum Qty out of range');
    when CHECK_MAXQTY_GREATER_MIXQTY then
        raise_application_error(-20222, 'Minimum Qty larger than Maximum Qty');
    when others then
        raise_application_error(-20000, SQLERRM);
end;

/

create or replace procedure ADD_LOCATION_VIASQLDEV (ploccode varchar2, pminqty number, pmaxqty number) as
begin
    dbms_output.put_line('--------------------------------------------');
    dbms_output.put_line('Adding Location LocCode: ' || ploccode || ' MinQty: ' || pminqty || ' MaxQty: ' || pmaxqty);
    ADD_LOCATION_TO_DB(ploccode, pminqty, pmaxqty);
    dbms_output.put_line('Location Added OK');
    commit;
exception
    when others then
        dbms_output.put_line(sqlerrm);
end;

/


-- PART 4 --

--PART 4.1--
--2/5 - exception--
create or replace procedure ADD_COMPLEX_SALE_TO_DB (pcustid number, pprodid number, pqty number, pdate varchar2) as
    invalid_status exception;
    invalid_qty exception;
    invalid_date exception;
    no_customer exception;
    no_product exception;
    prod_price number;
    pstatus varchar2(10);
    sale_date date;
    error number := 0;
begin
    select status into pstatus 
    from CUSTOMER where pcustid = custid;
    error := 1;
    
    select selling_price into prod_price 
    from PRODUCT where pprodid = prodid;
    
    if LOWER(pstatus) != 'ok' then
        raise invalid_status;
    end if;
    if pqty < 1 or pqty > 999 then
        raise invalid_qty;
    end if;
    
    if length(pdate) != 8 then
        raise invalid_date;
    end if;
    sale_date := to_date(pdate, 'YYYYMMDD');
    
    insert into SALE(saleid, custid, prodid, qty, price, saledate)
    values (SALE_SEQ.nextval, pcustid, pprodid, pqty, prod_price, sale_date);
    
    UPD_CUST_SALESYTD_IN_DB(pcustid, pqty*prod_price);
    UPD_PROD_SALESYTD_IN_DB(pprodid, pqty*prod_price);
exception
    when invalid_qty then
        raise_application_error(-20233, 'Sale Quantity outside valid range');
    when invalid_status then
        raise_application_error(-20247, 'Customer status is not OK');
    when invalid_date then
        raise_application_error(-20251, 'Date not valid');
    when no_data_found then
        if error = 0 then
            raise_application_error(-20265, 'Customer ID not found');
        else
            raise_application_error(-20272, 'Product ID not found');
        end if;
    when others then
        raise_application_error(-20000, SQLERRM);
end;

/

create or replace procedure ADD_COMPLEX_SALE_VIASQLDEV (pcustid number, pprodid number, pqty number, pdate varchar2) as
    prod_price number;
begin
    select selling_price into prod_price 
    from PRODUCT where pprodid = prodid;
    
    dbms_output.put_line('--------------------------------------------');
    dbms_output.put_line('Adding Complex Sale. Cust Id: '|| pcustid || ' Prod Id: ' || pprodid || ' Date: ' || pdate || ' Amt: ' || pqty*prod_price);
    ADD_COMPLEX_SALE_TO_DB(pcustid, pprodid, pqty, pdate);
    dbms_output.put_line('Added Complex Sale OK');
    commit;
exception
    when others then
        dbms_output.put_line(sqlerrm);
end;

/

--2/2--
create or replace function GET_ALLSALES_FROM_DB return SYS_REFCURSOR as
    vCursor SYS_REFCURSOR;
begin
    open vCursor for select * from SALE;
    return vCursor;
exception
    when others then
        raise_application_error(-20000, SQLERRM);
end;

/

create or replace procedure GET_ALLSALES_VIASQLDEV as
    vCursor SYS_REFCURSOR;
    vRecord SALE%ROWTYPE;
begin
    dbms_output.put_line('Listing All Complex Sales Details');
    vCursor := GET_ALLSALES_FROM_DB;
    if vCursor%NOTFOUND then 
        dbms_output.put_line('No rows found');
    end if;
    
    loop
        fetch vCursor into vRecord;
        exit when vCursor%NOTFOUND;
        dbms_output.put_line('Saleid: ' || vRecord.saleid || ' Prodid: ' || vRecord.prodid || ' Date: ' || vRecord.saledate || ' Amount: ' || vRecord.price * vRecord.qty);
    end loop;
    close vCursor;
    
    commit;
exception
    when others then
        dbms_output.put_line(sqlerrm);
end;

/

--3/3--
create or replace function COUNT_PRODUCT_SALES_FROM_DB (pdays number) return number as
    vCount number;
begin
    select count(*) into vCount
    from SALE where pdays > sysdate - saledate;
    return vCount;
exception
    when others then
        raise_application_error(-20000, SQLERRM);
end;

/

create or replace procedure COUNT_PRODUCT_SALES_VIASQLDEV (pdays number) as
    vCount number;
begin
    dbms_output.put_line('--------------------------------------------');
    dbms_output.put_line('Counting sales within ' || pdays || ' days');
    vCount := COUNT_PRODUCT_SALES_FROM_DB(pdays);
    dbms_output.put_line('Total number of sales: ' || vCount);
exception
    when others then
        dbms_output.put_line(sqlerrm);
end;

/

--PART 4.3--
--5/6 no rows exception--
create or replace function DELETE_SALE_FROM_DB return number as
    pid number;
    pqty number;
    pprice number;
    pprodid number;
    pcustid number;
    cust_sales number;
    prod_sales number;
begin
    select MIN(saleid) into pid 
    from SALE;
    if pid is null then
        raise no_data_found;
    end if;
    
    select qty, prodid, custid, price into pqty, pprodid, pcustid, pprice
    from SALE where pid = saleid;
    
    if SQL%NOTFOUND then
        raise no_data_found;
    end if;
    
    select sales_ytd into prod_sales 
    from PRODUCT where prodid = pprodid;
    select sales_ytd into cust_sales
    from CUSTOMER where custid = pcustid;
    
    delete from SALE where saleid = pid;
    UPD_CUST_SALESYTD_IN_DB(pcustid, - pqty*pprice);
    UPD_PROD_SALESYTD_IN_DB(pprodid, - pqty*pprice);

    return pid;
exception
    when no_data_found then
        raise_application_error(-20283, 'No Sale Rows Found');
    when others then
        raise_application_error(-20000, SQLERRM);
end;
    
/

create or replace procedure DELETE_SALE_VIASQLDEV as
    deleted_id number;
begin
    deleted_id := DELETE_SALE_FROM_DB;
    dbms_output.put_line('--------------------------------------------');
    dbms_output.put_line('Deleting Sale with smallest SaleId value');
    dbms_output.put_line('Deleted Sale OK. SaleID: ' || deleted_id);
    commit;
exception
    when others then
        dbms_output.put_line(sqlerrm);
end;
        
/
--4/4--
create or replace procedure DELETE_ALL_SALES_FROM_DB as
    refCursor SYS_REFCURSOR;
    cust_empty CUSTOMER%ROWTYPE;
    prod_empty PRODUCT%ROWTYPE;
begin
    delete from SALE;
    
    open refCursor for select * from CUSTOMER;
    loop
        fetch refCursor into cust_empty;
        exit when refCursor%NOTFOUND;
        UPD_CUST_SALESYTD_IN_DB(cust_empty.custid, -cust_empty.sales_ytd);
    end loop;
    close refCursor;
    
    open refCursor for select * from PRODUCT;
    loop
        fetch refCursor into prod_empty;
        exit when refCursor%NOTFOUND;
        UPD_PROD_SALESYTD_IN_DB(prod_empty.prodid, -prod_empty.sales_ytd);
    end loop;
    close refCursor;
exception
    when others then
        raise_application_error(-20000, SQLERRM);
end;
   
/

create or replace procedure DELETE_ALL_SALES_VIASQLDEV as
begin
    dbms_output.put_line('--------------------------------------------');
    dbms_output.put_line('Deleting all Sales data in Sale, Customer, and Product tables');
    DELETE_ALL_SALES_FROM_DB;
    dbms_output.put_line('Deletion OK');
    commit;
exception
    when others then
        dbms_output.put_line(sqlerrm);
end;

/

-- PART 5 --

--PART 5.1--
--2/3 exception--
create or replace procedure DELETE_CUSTOMER (pCustid number) as
    vCount number;
    no_data_found exception;
    child_exist exception;
begin
    select count(*) into vCount 
    from SALE where pCustid = custid;
    
    if vCount = 0 then
        delete from CUSTOMER
        where pCustid = custid;
        if SQL%NOTFOUND then
            raise no_data_found;
        end if;
    else
        raise child_exist;
    end if;
exception
    when no_data_found then
        raise_application_error(-20293, 'Customer ID not found');
    when child_exist then
        raise_application_error(-20307, 'Customer cannot be deleted as sales exist');
    when others then
        raise_application_error(-20000, SQLERRM);
end;

/

create or replace procedure DELETE_CUSTOMER_VIASQLDEV (pCustid number) as
begin
    dbms_output.put_line('--------------------------------------------');
    dbms_output.put_line('Deleting Customer. Cust Id: ' || pCustid);
    DELETE_CUSTOMER(pCustid);
    dbms_output.put_line('Deleted Customer OK.');
    commit;
exception
    when others then
        dbms_output.put_line(sqlerrm);
end;

/

--1/2 exception--
create or replace procedure DELETE_PROD_FROM_DB (pProdid number) as
    vCount number;
    child_exist exception;
begin
    select count(*) into vCount 
    from SALE where pProdid = prodid;
    
    if vCount = 0 then
        delete from PRODUCT
        where pProdid = prodid;
        if SQL%NOTFOUND then
            raise no_data_found;
        end if;
    else
        raise child_exist;
    end if;
exception
    when no_data_found then
        raise_application_error(-20313, 'Product ID not found');
    when child_exist then
        raise_application_error(-20327, 'Product cannot be deleted as sales exist');
    when others then
        raise_application_error(-20000, SQLERRM);
end;

/

create or replace procedure DELETE_PROD_VIASQLDEV (pProdid number) as
begin
    dbms_output.put_line('--------------------------------------------');
    dbms_output.put_line('Deleting Product. Product Id: ' || pProdid);
    DELETE_PROD_FROM_DB(pProdid);
    dbms_output.put_line('Deleted Product OK.');
    commit;
exception
    when others then
        dbms_output.put_line(sqlerrm);
end;

-- END OF PASS TASKS & CREDIT TASKS --

-- THE BELOW PACKAGE IS USED FOR PART 7 (HIGH DISTINCTION) --
/*create or replace package cursPackage as type t_cursor is ref cursor;
    procedure get_all_prod (i_cursor in out t_cursor);
    procedure get_all_cust (i_cursor in out t_cursor);
    procedure get_all_sale (i_cursor in out t_cursor);
end cursPackage;

create or replace package body cursPackage as 
    procedure get_all_prod (i_cursor in out t_cursor)
    is
        v_cursor t_cursor;
    begin
        v_cursor := GET_ALLPROD_FROM_DB;
        i_cursor := v_cursor;
    end get_all_prod;
    
    procedure get_all_cust (i_cursor in out t_cursor)
    is
        v_cursor t_cursor;
    begin
        v_cursor := GET_ALLCUST;
        i_cursor := v_cursor;
    end get_all_cust;
    
    procedure get_all_sale (i_cursor in out t_cursor)
    is
        v_cursor t_cursor;
    begin
        v_cursor := GET_ALLSALES_FROM_DB;
        i_cursor := v_cursor;
    end get_all_sale;
    
end cursPackage;*/
    









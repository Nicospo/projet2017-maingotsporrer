drop table if exists USER;
drop table if exists WIFIACCOUNT;
drop table if exists NORMALACCOUNT;


create table USER (
    user_id integer not null primary key auto_increment,
    user_login varchar(50) not null,
    user_password varchar(50) not null,
    user_passwordstrength integer not null
) engine=innodb character set utf8 collate utf8_unicode_ci;

create table WIFIACCOUNT (
    wifiaccount_id integer not null primary key auto_increment,
    wifiaccount_password varchar(50) not null,
    wifiaccount_login varchar(50),
    wifiaccount_userid integer not null,
    wifiaccount_passwordstrength integer not null,
    wifiaccount_ssid varchar(50) not null,
    wifiaccount_name varchar(50) not null
) engine=innodb character set utf8 collate utf8_unicode_ci;

create table NORMALACCOUNT (
    normalaccount_id integer not null primary key auto_increment,
    normalaccount_password varchar(50) not null,
    normalaccount_login varchar(50),
    normalaccount_userid integer not null,
    normalaccount_passwordstrength integer not null,
    normalaccount_name varchar(50) not null  
) engine=innodb character set utf8 collate utf8_unicode_ci;

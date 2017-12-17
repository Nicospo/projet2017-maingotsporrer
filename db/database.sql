create database if not exists projetglog character set utf8 collate utf8_unicode_ci;
use projetglog;

grant all privileges on projetglog.* to 'projetglog_user'@'localhost' identified by 'secret';

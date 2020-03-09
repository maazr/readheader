USE [master]
GO

/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [nu]    Script Date: 3/8/2020 9:44:07 PM ******/
CREATE LOGIN [nu] WITH PASSWORD=N'PF6cnScnc4BX1XweFWSgGePjMfl+UAh1RiCxzs2xKwE=', DEFAULT_DATABASE=[master], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO

ALTER LOGIN [nu] DISABLE
GO



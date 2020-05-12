# readheader
Read Header of csv file and remove duplicates column heading. 
Files are very wide meaning too many columns. Files contain data collected from some web site.
Problem is when data is downloaded there are many section in header of these file.
> There could be different file depending upon different source.

This utility reades the header and rename duplicate columns in sequence 
eg: if section 1 one column with a header called "payment" and section 5 might also have same column with header called "payment"
task is to rename second one as payment_2 and third occurance as payment_3 so on and so forth.

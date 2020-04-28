# readheader
Read Header of csv file and remove duplicates 
Files are very wide files for data collected from some web site.
Problem is when data is download there are many section in header of file
There could be different file depending upon different source.

This utility reades the header and rename duplicate columns in sequence 
eg: if section 1 one column with a header called "payment" and section 5 might also have same column with header called "payment"
task is to rename second one as payment_2 and third occurance as payment_3 so on and so forth.


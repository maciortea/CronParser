## Cron expression parser
This project is a command line tool, which parses a `cron` string and expands each field to show the times at which it will run.

### Example
For the following input argument `*/15 0 1,15 * 1-5 /usr/bin/find` the program will output to console:
```
minute 0 15 30 45
hour 0
day of month 1 15
month 1 2 3 4 5 6 7 8 9 10 11 12
day of week 1 2 3 4 5
command /usr/bin/find
```

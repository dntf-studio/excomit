@echo off

if "%1" == "-d" (
    go run reader.go
    go build reader.go
) else if "%2" == "-b" (
    reader
)
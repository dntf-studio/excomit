package main

import (
	"bufio"
	"errors"
	"fmt"
	"os"
	"strings"

	"github.com/fatih/color"
)

/*
Code by dntf-studio @2021

source : https://github.com/dntf-studio/excomit/blob/master/excomit/bin/Debug/reader.go
*/

func main() {

	var list []string
	list, err := read(".txt")
	if err != nil {
		fmt.Println("Eorror was detected")
		os.Exit(1)
	}
	write(list)
	ff := false

reload:

	var lis_t []string
	lis_t, errr := read("note.txt")
	if errr != nil {
		fmt.Println("Eorror was detected")
		os.Exit(1)
	}
	if ff {
		write(lis_t)
	}

scan:

	scanner := bufio.NewScanner(os.Stdin)
	scanner.Scan()
	str := scanner.Text()
	str = strings.TrimSpace(str)

	s, e := judgeman(str)
	if e != nil {
		fmt.Println("error: ", e.Error())
		confilm()
	} else {
		if s == "r" {
			ff = true
			goto reload
		} else if s == "h" {
			help()
			goto scan
		} else if s == "v" {
			info()
			goto scan
		}
	}
}

func info() {
	w := color.New(color.FgHiGreen, color.Underline)
	fmt.Println("v.0.9.1.a :")
	fmt.Println("	excomit is opensource softwere && made by dntf-studio @2021")
	fmt.Println("	repository: https://github.com/dntf-studio/excomit")
	fmt.Println("	this app(Go) source: https://github.com/dntf-studio/excomit/blob/master/excomit/bin/Debug/reader.go")
	w.Print("\n>>")
}

func help() {
	w := color.New(color.FgHiGreen, color.Underline)
	fmt.Println("commands:")
	fmt.Println("	'r' = reload page with new data")
	fmt.Println("	'h' = help")
	fmt.Println("	'v' = about this app")
	w.Print("\n>>")
}

func write(l []string) {
	w1 := color.New(color.FgHiGreen)
	w2 := color.New(color.FgHiYellow, color.Underline)
	for i, v := range l {
		comm := strings.Split(v, ",")
		if i == 0 {
			w1.Println("_________________________________")
			w1.Println("| ", i, "  ", comm[0], "  ", comm[1])
		} else if i < 10 {
			w1.Println("| ", i, "  ", comm[0], "  ", comm[1])
		} else {
			w1.Println("|", i, "  ", comm[0], "  ", comm[1])
		}
	}
	w2.Println("\n               $$残り人数: ", len(l), "人$$              ")
	w1.Add(color.Underline)
	w1.Print("\n>>")
}

func judgeman(s string) (string, error) {
	if strings.ToLower(s) == "r" {
		return "r", nil
	} else if strings.ToLower(s) == "h" {
		return "h", nil
	} else if strings.ToLower(s) == "v" {
		return "v", nil
	} else {
		err := errors.New("incorrect command")
		return "", err
	}
}

func confilm() {
	w3 := color.New(color.FgHiRed)
	w3.Print("are you sure quit?(Y/N) ")
	scanner := bufio.NewScanner(os.Stdin)
	scanner.Scan()
	s := scanner.Text()
	s = strings.TrimSpace(s)

	if strings.ToUpper(s) == "Y" {
		os.Exit(0)
	} else if strings.ToUpper(s) == "N" {
		main()
	} else {
		w3.Println("plz put in with 'Y' or 'N'")
		confilm()
	}
}

func read(fn string) ([]string, error) {
	var list []string
	file, err := os.Open(fn)
	if err != nil {
		return nil, err
	}
	defer file.Close()

	reader := bufio.NewScanner(file)
	for reader.Scan() {
		line := reader.Text()
		list = append(list, line)
	}

	if err := reader.Err(); err != nil {
		return nil, err
	}

	return list, nil
}

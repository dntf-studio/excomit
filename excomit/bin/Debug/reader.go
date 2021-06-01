package main

import (
	"bufio"
	"fmt"
	"os"
	"strings"
)

func main() {
	fmt.Println("a")
	var list []string
	err, list := read(".txt")
	if err != nil {
		fmt.Println("Eorror was detected")
		os.Exit(1)
	}

	for i, v := range list {
		comm := strings.Split(v, ",")
		if i == 0 {
			fmt.Println("_________________________________")
			fmt.Println("| ", i, "  ", comm[0], "  ", comm[1])
		} else if i < 10 {
			fmt.Println("| ", i, "  ", comm[0], "  ", comm[1])
		} else {
			fmt.Println("|", i, "  ", comm[0], "  ", comm[1])
		}
	}

	fmt.Print(">>")
	scanner := bufio.NewScanner(os.Stdin)
	scanner.Scan()
}

func read(fn string) (error, []string) {
	var list []string
	file, err := os.Open(fn)
	if err != nil {
		return err, nil
	}
	defer file.Close()

	reader := bufio.NewScanner(file)
	for reader.Scan() {
		line := reader.Text()
		list = append(list, line)
	}

	if err := reader.Err(); err != nil {
		return err, nil
	}

	return nil, list
}

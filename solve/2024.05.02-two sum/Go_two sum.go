func twoSum(nums []int, target int) []int {
    m := make(map[int]int)
    for index, val := range nums {
        if preIndex, ok := m[target-val]; ok {
            return []int{preIndex, index}
        } else {
            m[val] = index
        }
    }
    return []int{}
}


# 短宣告 m 為 map，並透過 make 初始化， map[keyType]ValueType
m := make(map[string]int)


# a,b := expression; a 給值，b 為 bool
# 所以 preIndex, ok := m[target-val] 會回傳 m[target-val] 的值給 preIndex，
# 並且判斷是否存在，bool 值給 ok，再透過 ok 決定是否執行 if 內的程式碼
if preIndex, ok := m[target-val]; ok {
	return []int{preIndex, index}
}
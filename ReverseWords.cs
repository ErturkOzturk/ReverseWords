//Runtime 48 ms Memory 40.68 MB
public string ReverseWords(string s) {
    return String.Join(" ", s.Split(" ").Where(x => !string.IsNullOrEmpty(x.Trim())).Reverse());
}

//Runtime 48 ms Memory 61.99 MB
public string ReverseWords2(string s) {
    string[] list = s.Split(" ");
    string result = "";
    for(int i=list.Length; i>0; i--){
        result += String.IsNullOrEmpty(list[i-1])?"":list[i-1]+" ";
    }
    return result.Trim();
}

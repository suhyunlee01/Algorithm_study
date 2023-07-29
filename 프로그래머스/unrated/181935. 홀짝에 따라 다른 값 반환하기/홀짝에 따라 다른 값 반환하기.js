function solution(n) {
    var sum = 0;
    if (n % 2 == 0) {
        for (var i = 1; i <= n; i++) {
            if (i % 2 == 0) {
                sum = sum + (i**2);
            }
        }
    } else if (n % 2 == 1) {
        for (var j = 1; j <= n; j++) {
            if (j % 2 == 1) {
                sum = sum + j;
            }
        }
    }
    return sum;
}
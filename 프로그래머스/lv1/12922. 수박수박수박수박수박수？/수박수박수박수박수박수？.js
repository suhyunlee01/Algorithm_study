function solution(n) {
    var answer = '';
    for (var i = 0; i < n; i++) {
        if (i % 2 == 0) {
            answer = answer+ '수';
        } else {
            answer = answer+ '박';
        }
    }
    return answer;
}
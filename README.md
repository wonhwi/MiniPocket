# MiniPocket

이 프로젝트는 젠킨스 자동화 빌드 구축 후 개발 진행 예정입니다.

추후 젠킨스 자동화 구축 과정도 기재할 예정입니다.

#2024 - 05 - 27
1. 젠킨스 시스템 구축 완료
- JenKins를 LocalHost로 구성을 했을때 GitHub의 WebHook을 받지 못해 자동 빌드를 못하는 문제 발생 포트포워딩과 방화벽 인바운드 설정을 통해 문제 해결.
- Commit시 마다 자동 빌드를 하기 때문에 분기를 나눠줄 필요성을 느낌 분기 나눌 예정
- 업데이트 일지도 어떻게 추가해 줄지 고민 중 

#2024-08-19
1. 젠킨스 외부 IP 접속 문제 확인
-> IP가 고정이 아닌 유동 IP로 인해 Local IP 변경 DHCP 에 변경 IP 추가
위에 방법 말고 고정 IP로 설정하는 방법으로도 해결 가능

2. Jenkins Agent 추가 예정

3. SSH(Secure Shell) 인증 자격 증명 변경
RSA -> Ed25519

4. 추후 구글 드라이브로 빌드 된 파일 업로드 예정

5. Jenkins Editor command line aguments 수정
-quit -batchmode -logFile "$WORKSPACE/JenkinsBuild.log" -buildTarget win64 -project Path "D:\GitHub\Project\MiniPocket"  -executeMethod BuildPlayer.BuildStandaloneWindows
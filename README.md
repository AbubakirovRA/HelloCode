# HelloCode
1 lesson Intro in Programming
Лекции профессора Камянецкого по программированию на языке C#. 
В данном репозитории помещены примеры программ созданных во время лекции.

Решение ошибки a shot of dev knowledge “fatal: refusing to merge unrelated histories”, то есть когда утеряны данные о проекте, либо объединяются два разных проекта: git pull origin main --allow-unrelated-histories.

Взял отсюда: https://www.educative.io/edpresso/the-fatal-refusing-to-merge-unrelated-histories-git-error

Еще одна волшебная команда для Git, позволяет в старом престаром коммите удалить какой-нибудь файл. Например, я по ошибке закомитил вместе со всеми нужными файлами, дистрибутив программы, который весил более 200 мб и после этого, даже после удаления файла все пуши останавливались по размеру репозитория. Помогло удаление файла из самого коммита, причем он, коммит, был самый первый.

git filter-branch --force --index-filter "git rm --cached --ignore-unmatch Относительный_путь_в_корне_репозитория/bigfile.exe" -- --all

взял отсюда: https://translated.turbopages.org/proxy_u/en-ru.ru.71ed2b1c-637fbc7e-8db5205e-74722d776562/https/stackoverflow.com/questions/8740187/git-how-to-remove-file-from-historical-commit

Нужные команды к выше указанной: git log  ---> git show --stat номер_выбранного_коммита

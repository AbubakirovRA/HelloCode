# HelloCode
1 lesson Intro in Programming
Лекции профессора Камянецкого по программированию на языке C#. 
В данном репозитории помещены примеры программ созданных во время лекции.

Решение ошибки a shot of dev knowledge “fatal: refusing to merge unrelated histories”, то есть когда утеряны данные о проекте, либо объединяются два разных проекта: 

git pull origin main --allow-unrelated-histories

Взял отсюда: https://www.educative.io/edpresso/the-fatal-refusing-to-merge-unrelated-histories-git-error

Еще одна волшебная команда для Git, позволяет в старом престаром коммите удалить какой-нибудь файл. Например, я по ошибке закомитил вместе со всеми нужными файлами, дистрибутив программы, который весил более 200 мб и после этого, даже после удаления файла все пуши останавливались по размеру репозитория. Помогло удаление файла из самого коммита, причем он, коммит, был самый первый. До выполнения команды нужно все последние изменения закоммитить.

git filter-branch --force --index-filter "git rm --cached --ignore-unmatch Относительный_путь_в_корне_репозитория_к_файлу_который_был_запушен_ошибочно" -- --all

Например:
git filter-branch --index-filter "git rm --cached --ignore-unmatch testrail-7.5.3.1000-ion72.zip" --tag-name-filter cat -- --all


взял отсюда: https://stackoverflow.com/questions/8740187/git-how-to-remove-file-from-historical-commit

Нужные команды к выше указанной: git log  ---> git show --stat номер_выбранного_коммита


## Слияние Main и Master
Если локальное хранилище у вас уже существовало, то ни к чему было создавать коммит на сервере github.com (об этом там явно написано: пропустите этот шаг, если локальное хранилище у вас уже есть). но будем исходить из предположения, что сгенерированное сервером содержимое файла .gitignore вам остро необходимо. это допущение номер раз.

следующая проблема, с которой вы столкнулись, проистекает из сумасбродства (моё оценочное суждение) владельцев сервера github.com — в то время как программа git создаёт по умолчанию ветку с именем master, не так давно они решили у себя на сервере создавать ветку с именем main. будем исходить из предположения, что вы согласны пойти у них на поводу и использовать имя main как локально, так и в копии вашего хранилища на их сервере. это допущение номер два.

итак, что у вас есть?

в локальном хранилище ветка master с одним или несколькими коммитами.
в хранилище на github.com ветка main с одним коммитом, в котором создан автоматически сгенерированный файл .gitignore.
что хотим получить?

локальное хранилище с веткой main, содержащее как коммиты из локальной ветки master, так и коммит, созданный в ветке main на сервере github.com
идентичную картину и в хранилище на сервере github.com
план действий:

если ещё не подключили к своему локальному хранилищу то хранилище, что создали на сервере, то подключите и заберите оттуда информацию:

+ $ git remote add origin git@github.com:имя-вашей-учётной-записи/имя-хранилища
+ $ git fetch --all

если вдруг текущей у вас объявлена не ветка master, то сделайте её таковой:
+ $ git checkout master

добавьте в эту ветку коммит, созданный сервером в ветке main (содержащий создание автосгенерированного файла .gitignore):
+ $ git cherry-pick origin/main

создайте локальную ветку main, которая будет указывать (ветка в git — это ведь просто плавающий указатель, верно?) на тот же коммит, что и master:
+ $ git branch -f main master

теперь сделайте ветку main текущей:
+ $ git checkout main

удалите ветку master:
+ $ git branch -D master

и отправьте ветку main на сервер, делая одновременно и перезапись (опция -f) привязку локальной ветки к ветке на сервере (опция -u):
+ $ git push -f -u origin main

на этом всё. доп. чтение:
+ $ man git-remote
+ $ man git-fetch
+ $ man git-checkout
+ $ man git-cherry-pick
+ $ man git-branch
+ $ man git-push


Чтобы удалить ветку из локального Git-репозитория, выполните: git branch -d <имя_ветки>. Чтобы удалить ветку из удаленного Git-репозитория, выполните: git push origin --delete <имя_ветки>. Для просмотра изменений одного файла, можно воспользоваться следующей командой: Изменения по коммитам git log -p FILE_NAME.



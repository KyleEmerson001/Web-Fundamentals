def class_grades():
    students = []
    number_of_inputs = 0
    while True:
        try:
            number_of_students = int(input("How many students do you have? "))
        except ValueError:
            print("sorry please input a number")
            continue
        else:
            break
    while int(number_of_inputs) < int(number_of_students):
        while True:
            try:
                student_name = str(input("Student's name: "))
            except ValueError:
                print("sorry please input a name")
                continue
            else:
                break
        while True:
            try:
                student_grade = int(input("Student's grade: "))
            except ValueError:
                print("sorry please input a number")
                continue
            else:
                break
        while True:
            try:
                student_course = int(input("Select a course: 1 - Math, 2 - Science, 3 - History: "))
            except ValueError:
                print("sorry please input a number between 1 amd 3")
                continue
            
            if student_course <0 or student_course > 3:
                print("sorry please input a number between 1 amd 3")
                continue
            else:
                break
        new_student = {}
        new_student["name"] = student_name
        new_student["grade"] = str(student_grade)
        new_student["course"] = str(student_course)
        students.append(new_student)
        number_of_inputs += 1
    for x in range(len(students)):
        print("Name: " + students[x]['name'] + " Grade: "+ students[x]['grade'] + " Course: " + students[x]['course'])
class_grades()
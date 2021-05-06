def class_grades():
    students = []
    number_of_inputs = 0
    number_of_students = input("How many students do you have? ")
    if input != int:

        number_of_students = input("How many students do you have? ")

    while int(number_of_inputs) < int(number_of_students):
        student_name = input("Student's name: ")
        student_grade = input("Student's grade: ")
        student_course = input("Select a course: 1 - Math, 2 - Science, 3 - History: ")
        new_student = {}
        new_student["name"] = student_name
        new_student["grade"] = student_grade
        new_student["course"] = student_course
        students.append(new_student)
        number_of_inputs += 1
    for x in range(len(students)):
        print("Name: " + students[x]['name'] + " Grade: "+ students[x]['grade'] + " Course: " + students[x]['course'])
class_grades()

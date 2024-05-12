# Plik CMake 
# 
# Używany do ułatwienia kompilacji programu
# Jeżeli nie umiesz korzystać z CMake, to nie musisz go używać,
# ale wtedy musisz samodzielnie skompilować program
# 
# Kod nie korzysta z żadnych zewnętrznych zależności, 
# więc aby go skompilować wystarczy że wkleisz treść pliku main.cpp 
# do swojego kompilatora C++ (np. Visual Studio).

# Ustawiamy minimalną wersję CMake
CMAKE_MINIMUM_REQUIRED_VERSION(3.0)

# Ustawiamy nazwę projektu
PROJECT(Zadanie 1 - INF-04 C++ - Styczen 2024)

# Ustawiamy standard C++ na C++11
SET(CMAKE_CXX_STANDARD 11)
SET(CMAKE_CXX_STANDARD_REQUIRED ON)

# Dodajemy pliki źródłowe
SET(SOURCE_FILES
    main.cpp)

# Dodajemy plik wykonywalny
ADD_EXECUTABLE(${PROJECT_NAME} ${SOURCE_FILES})
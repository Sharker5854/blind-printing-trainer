import sqlite3


class FileMode:
    Letter = "letter"
    Word = "word"
    Sentence = "sentence"


class DBFiller:
    _con = None
    letters = []
    words = []
    sentences = []

    def __init__(self, database_path: str) -> None:
        """Connect to SQLite Database"""
        self._con = sqlite3.connect(database_path)

    def read_file(self, file_path: str, mode: str) -> None:
        """Collect data from the files depending on the mode"""
        match mode:
            case FileMode.Letter:
                self.letters = set(self._read_letters_from_file(file_path))
            case FileMode.Word:
                self.words = set(self._read_words_from_file(file_path))
            case FileMode.Sentence:
                self.sentences = set(self._read_sentences_from_file(file_path)).difference({"",})

    def _read_letters_from_file(self, path) -> list:
        """ Collect data specially from the file with symbols (no separators) """
        with open(path, mode="r", encoding="utf-8") as file:
            return [str(symbol) for symbol in file.read()]
        
    def _read_words_from_file(self, path) -> list:
        """ Collect data specially from the file with words (separator: ', ') """
        with open(path, mode="r", encoding="utf-8") as file:
            return file.read().split(", ")
        
    def _read_sentences_from_file(self, path) -> list:
        """ Collect data specially from the file with sentences (separator: '. ') """
        with open(path, mode="r", encoding="utf-8") as file:
            return file.read().split(".\n")
        
    def write_in_db(self, mode: str) -> None:
        """Write data into the database"""
        if self.exercise_table_exists():
            self.make_write_query(mode)
        else:
            self.create_exercise_table()
            self.make_write_query(mode)
        
    def exercise_table_exists(self) -> bool:
        """Check if Exercise table already exists"""
        with self._con as con:
            data = con.execute("select count(*) from sqlite_master where type='table' and name='Exercises'")
            for row in data:
                if row[0] == 0:
                    return False
                return True

    def create_exercise_table(self) -> None:
        """Create Exercise table (if it doesn't exists)"""
        with self._con as con:
            con.execute("""
                CREATE TABLE "Exercises" (
                    "id"	INTEGER NOT NULL UNIQUE,
                    "type"	TEXT NOT NULL,
                    "value"	TEXT NOT NULL UNIQUE,
                    PRIMARY KEY("id" AUTOINCREMENT)
                );
            """)

    def make_write_query(self, mode: str):
        """Execute INSERT query to database for writing data"""
        match mode:
            case FileMode.Letter:
                content = [("letter", value) for value in self.letters]
            case FileMode.Word:
                content = [("word", value) for value in self.words]
            case FileMode.Sentence:
                content = [("sentence", value) for value in self.sentences]
        with self._con as con:
            con.executemany(
                "INSERT INTO Exercises (type, value) values(?, ?)",
                content
            )
        

def main() -> None:
    filler = DBFiller(database_path="./Trainer/trainer_database.db")                                    # specify path to database
    filler.read_file(file_path="./Exercise_sources/letter_exercises.txt", mode=FileMode.Letter)         # reading data from file with letters
    filler.read_file(file_path="./Exercise_sources/word_exercises.txt", mode=FileMode.Word)             # reading data from file with words
    filler.read_file(file_path="./Exercise_sources/sentence_exercises.txt", mode=FileMode.Sentence)     # reading data from file with sentences
    filler.write_in_db(FileMode.Letter)                                                                 # writing letters from file into database table
    filler.write_in_db(FileMode.Word)                                                                   # writing words from file into database table
    filler.write_in_db(FileMode.Sentence)                                                               # writing sentences from file into database table

if __name__ == "__main__":
    main()
import os
import sys
import re
from collections import deque
import fileinput
import hashlib
from tempfile import mkstemp
from shutil import move, copymode
from os import fdopen, remove


# CONSTANTS
ENCODING = "latin1"
WALK_DIR = "C:\git\RayStation"
#WALK_DIR = "C:\git\RayStation\CorePlatform\CoreUtilities.NET\CoreUtilities.NET\QuantityExjobb"
LOG_FILE_PATH = os.path.join(WALK_DIR, 'output.txt')
LOGGING = False
VERBOSE = True
ONLY_SHOW_CHANGE = False
DUP_SIZE = 6
DUP_STR_SPLIT_SYM = '\n'

# CLASSES
class Stats():
    def __init__(self, dup_size):
        self.changed_files = 0
        self.total_files = 0
        self.changed_lines = 0
        self.total_lines = 0
        self.duplicates_hashes = {}
        self.duplicates_new_hashes = {}
        self.duplicates_result = {}
        self.duplicates_new_result = {}
        self.dup_size = dup_size
        self.second_time = False

    def check_duplicate(self, q, line):
        line = line.strip()
        if not re.match(r'^\s*//', line) and not re.match(r'^\s*using', line) and not re.match(r'^\s*$', line):
            q.append(line)
            if len(q) == self.dup_size:
                stats.add_hash(q)
                q.popleft()

    def add_hash(self, q):
        string = DUP_STR_SPLIT_SYM.join(list(q))
        h = hashlib.sha512(string.encode(ENCODING))
        h = h.hexdigest()

        if h in self.duplicates_hashes and not self.second_time:
            self.duplicates_hashes[h][0] = self.duplicates_hashes[h][0] + 1
        elif not self.second_time:
            self.duplicates_hashes[h] = [0, string]

        if not h in self.duplicates_hashes and self.second_time:
            if h in self.duplicates_new_hashes:
                self.duplicates_new_hashes[h][0] = self.duplicates_new_hashes[h][0] + 1
            else:
                self.duplicates_new_hashes[h] = [0, string]

    def add_result(self):
        s = 0
        d = stats.duplicates_hashes.items()
        for _, v in d:
            s = s + v[0]
        self.duplicates_result[self.dup_size] = s
        return self.dup_size, s

    def add_new_result(self):
        s = 0
        d = stats.duplicates_new_hashes.items()
        for _, v in d:
            s = s + v[0]
        self.duplicates_new_result[self.dup_size] = s
        return self.dup_size, s

    def print_results(self):
        for k,v in self.duplicates_result.items():
            print('dup size: {}, duplicates: {}'.format(k, v))
            
    def print_new_results(self):
        for k,v in self.duplicates_new_result.items():
            print('dup size: {}, duplicates: {}'.format(k, v))

    def change_dup_size(self, ds):
        self.dup_size = ds
        self.duplicates_hashes = {}
        

# FUNCTIONS
def filename_filter(filename) -> bool:
    if (bool(re.search("CustomUpgrade", filename, 0))):
        return False
    if (bool(re.search("DbSchemaUpgrades", filename, 0))):
        return False
    return (bool(re.search("\.cs$", filename, 0)))

def log(msg: str) -> None:
    if LOGGING:
        with open(LOG_FILE_PATH, 'wb') as output_file:
            output_file.write(msg.encode("utf-8"))
            output_file.write(b"\n")

def vprint(msg) -> None:
    if VERBOSE:
        print(msg)

def print_stats(stats) -> None:
    print("Total files:", stats.total_files)
    print("Changed files:", stats.changed_files)
    print("Total lines:", stats.total_lines)
    print("Changed lines:", stats.changed_lines)

def main(stats) -> None:
    q = deque()

    for root, subdirs, files in os.walk(WALK_DIR):
        for filename in files:
            if not filename_filter(filename):
                continue
            stats.total_files = stats.total_files + 1
            file_path = os.path.join(root, filename)
            with open(file_path, 'rb') as f:
                for line in f:
                    stats.total_lines = stats.total_lines + 1
                    stats.check_duplicate(q, line.decode(ENCODING))

if __name__ == "__main__":
    stats = Stats(0)
    #for d in [1,2,4,6,10,20,40]:
    #    stats.change_dup_size(d)
    #    main(stats)
    #    n, s = stats.add_result()
    #stats.print_results()

    cnt = 1
    while True:
        stats.change_dup_size(cnt)
        main(stats)
        n, s = stats.add_result()
        print(n, s)
        if s == 0:
            break
        cnt = cnt + 1
    stats.print_results()

    d = stats.duplicates_hashes.items()
    sorted_d = {k: v for k, v in sorted(d, key=lambda item: item[1], reverse=True)}
    c = 0
    for k, v in sorted_d.items():
        print(v[0])
        print(v[1])
        if c == 5:
            break
        c = c + 1


    #stats.change_dup_size(1)
    #main(stats)
    #n, s = stats.add_result()
    #stats.print_results()
    #input("Press Enter to continue...")
    #stats.second_time = True
    #main(stats)
    #n, s = stats.add_new_result()
    #stats.print_new_results()
    #print()
#
    #d = stats.duplicates_new_hashes.items()
    #sorted_d = {k: v for k, v in sorted(d, key=lambda item: item[1], reverse=True)}
    #c = 0
    #for k, v in sorted_d.items():
    #    print(v[0])
    #    print(v[1])
    #    if c == 20:
    #        break
    #    c = c + 1
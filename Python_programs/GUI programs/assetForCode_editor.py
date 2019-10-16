import re

s = "subract(128-123)"
m = re.search(r"\(([A-Za-z0-9_-]+)\)", s)
print eval(m.group(1))

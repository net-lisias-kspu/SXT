#!/bin/bash

grep -r 'Squad/Parts' * -r --include=\*.cfg | grep -v PartDatabase | cut -f2 -d'=' | cut -f2 -d','

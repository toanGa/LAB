#include <stdio.h>
#include <math.h>
#include <stdlib.h>

#define MAX_N 32
#define MAX_K 31
#define HASH_VAL_BITS 16
#define HASHSIZE 10000
#define NOHASH -1


long random();
int srandom(int seed);

typedef struct hashEntry{
  unsigned long key;
  unsigned short val;
  struct hashEntry *next;
} HashEntry;

typedef HashEntry *HashTable[HASHSIZE];

static HashTable *nkModel[MAX_N];
static int n;
static int k;



long nkRand(int k)
{
  return (long) (random() / (pow(2, 31 - k) - 1));
}


int getHash(unsigned long key, HashTable hashTable)
{

  HashEntry *hashEntry;

  hashEntry = hashTable[key % HASHSIZE];
  while (hashEntry && hashEntry->key != key)
    hashEntry = hashEntry->next;
  if (hashEntry)
    return hashEntry->val;
  else
    return NOHASH;
}


void putHash(int val, unsigned long key, HashTable hashTable)
{
  HashEntry *newEntry;

  if (key < 0 || key >= pow(2, k + 1)) {
    fprintf(stderr, "Hash key is out of range\n");
    exit(1);
  }
  if (newEntry = (HashEntry *) malloc(sizeof(HashEntry))) {
    newEntry->key = key;
    newEntry->val = val;
    newEntry->next = hashTable[key % HASHSIZE];
    hashTable[key % HASHSIZE] = newEntry;
  }
  else {
    fprintf(stderr, "Unable to malloc space for new hash entry\n");
    exit(1);
  }
}



double evalLocus(char *pattern, int locus)
{
  unsigned long key;
  int val;

  key = strtol(pattern, (char **) NULL, 2);
  if ((val = getHash(key, *nkModel[locus])) == NOHASH)
    putHash(val = nkRand(HASH_VAL_BITS), key, *nkModel[locus]);
  return val / pow(2, HASH_VAL_BITS);
}



double evalString(char *string)
{
  char pattern[MAX_N + 1];
  int i, j;
  int offset = n - (k / 2);
  double sum = 0.0;

  pattern[k + 1] = '\0';
  for (i = 0; i < n; i++) {
    for (j = 0; j <= k; j++)
      pattern[j] = string[(i + j + offset) % n];
    sum += evalLocus(pattern, i);
  }
  return sum / n;
}



void *initModel(int nSize, int kSize, int preload)
{
  int i;
  unsigned long j;

  n = nSize;
  k = kSize;

  if (n <= 0 || n > MAX_N) {
    fprintf(stderr, "N is out of range\n");
    exit(1);
  }
  if (k < 0 || k >= n) {
    fprintf(stderr, "K is out of range\n");
    exit(1);
  }


  for (i = 0; i < n; i++) {
    nkModel[i] = (HashTable *) malloc(sizeof(HashTable));
    for (j = 0; j < HASHSIZE; j++)
      (*nkModel[i])[j] = NULL;
  }

  if (preload) {

    for (i = 0; i < n; i++)
      for (j = 0; j < pow(2, k + 1); j++)
	putHash(nkRand(HASH_VAL_BITS), j, *nkModel[i]);
  }
}
